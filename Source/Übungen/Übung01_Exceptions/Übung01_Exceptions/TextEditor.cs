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
            File.WriteAllText(txtPath.Text, txtEditor.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtEditor.Text = File.ReadAllText(txtPath.Text);
        }
    }
}
