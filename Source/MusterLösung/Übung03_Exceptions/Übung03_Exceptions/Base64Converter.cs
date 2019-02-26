using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Übung02_Exceptions
{
    public partial class Base64Converter : Form
    {
        public Base64Converter()
        {
            InitializeComponent();
        }

        private void btnConvertBase64ToText_Click(object sender, EventArgs e)
        {
            var skippedFileCount = 0;
            var convertedFileCount = 0;

            btnConvertBase64ToText.Enabled = false;

            var base64Files = Directory.GetFiles(txtSourceFolder.Text);

            //Fehler - Was passiert wenn keine Dateien im Ordner enthalten sind?
            if (base64Files.Length == 0)
            {
                //Benachrichte den Benutzer dass das Verzeichnis leer ist und breche die Konvertierung ab. Alternativ könnte man hier auch Exceptions Handling einfügen.
                MessageBox.Show("Keine Dateien im Ordner. Konvertierung wurde abgebrochen.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Wenn davor der Fall mit 0 Dateien im Ordner nicht abgefangen werden würde, hätten wir hier eine DivideByZeroException die behandlet werden müsste.
            var progressStep = progressBar1.Maximum / base64Files.Length;

            //Fehler - Progressvalue wurde nicht zurückgesetzt
            progressBar1.Value = 0;

            if (!Directory.Exists(txtTargetFolder.Text))
                Directory.CreateDirectory(txtTargetFolder.Text);
            
            foreach(var file in base64Files)
            {
                try
                {
                    var source = new FileInfo(file);
                    var target = Path.Combine(txtTargetFolder.Text, source.Name);
                    var base64Data = File.ReadAllText(source.FullName);
                    var text = Encoding.UTF8.GetString(Convert.FromBase64String(base64Data));
                    File.WriteAllText(target, text);
                    convertedFileCount++;
                }
                catch (Exception)
                {
                    skippedFileCount++;
                }
                finally
                {
                    progressBar1.Value += progressStep;
                }
            }
            btnConvertBase64ToText.Enabled = true;

            if (skippedFileCount > 0)
            {
                //Ordner enhtält Dateien die nicht dem base64 Format entsprechen.
                MessageBox.Show($"{convertedFileCount} Dateien umgewandelt. {skippedFileCount} Dateien wurden nicht konvertiert, da es keine Base64 Dateien waren.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"{convertedFileCount} Dateien umgewandelt.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtSourceFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnSelectTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtTargetFolder.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
