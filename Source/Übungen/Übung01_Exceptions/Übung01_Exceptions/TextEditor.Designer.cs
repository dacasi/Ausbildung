namespace Uebung01_Exceptions
{
    partial class TextEditor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(25, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(1060, 26);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "test.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateiauswahl:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1197, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 40);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Laden";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1091, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEditor);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1303, 580);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor";
            // 
            // txtEditor
            // 
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(3, 22);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(1297, 555);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.Text = "";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1327, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtEditor;
    }
}

