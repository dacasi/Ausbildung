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

namespace Uebung01_Exceptions
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(txtPath.Text, txtEditor.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                txtEditor.Text = File.ReadAllText(txtPath.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Laden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
