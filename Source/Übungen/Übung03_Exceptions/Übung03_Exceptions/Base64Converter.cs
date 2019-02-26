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
            btnConvertBase64ToText.Enabled = false;

            var base64Files = Directory.GetFiles(txtSourceFolder.Text);

            var progressStep = progressBar1.Maximum / base64Files.Length;

            if (!Directory.Exists(txtTargetFolder.Text))
                Directory.CreateDirectory(txtTargetFolder.Text);
            
            foreach(var file in base64Files)
            {
                var source = new FileInfo(file);
                var target = Path.Combine(txtTargetFolder.Text, source.Name);
                var base64Data = File.ReadAllText(source.FullName);
                var text = Encoding.UTF8.GetString(Convert.FromBase64String(base64Data));
                File.WriteAllText(target, text);

                progressBar1.Value += progressStep;
            }
            btnConvertBase64ToText.Enabled = true;
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
