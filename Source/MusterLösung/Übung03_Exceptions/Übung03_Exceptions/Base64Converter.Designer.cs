namespace Übung02_Exceptions
{
    partial class Base64Converter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectTarget = new System.Windows.Forms.Button();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnConvertBase64ToText = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSelectTarget);
            this.groupBox1.Controls.Add(this.txtTargetFolder);
            this.groupBox1.Controls.Add(this.btnSelectSource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSourceFolder);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(517, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Einstellungen";
            // 
            // btnSelectTarget
            // 
            this.btnSelectTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTarget.Location = new System.Drawing.Point(487, 37);
            this.btnSelectTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectTarget.Name = "btnSelectTarget";
            this.btnSelectTarget.Size = new System.Drawing.Size(27, 20);
            this.btnSelectTarget.TabIndex = 5;
            this.btnSelectTarget.Text = "...";
            this.btnSelectTarget.UseVisualStyleBackColor = true;
            this.btnSelectTarget.Click += new System.EventHandler(this.btnSelectTarget_Click);
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetFolder.Location = new System.Drawing.Point(83, 37);
            this.txtTargetFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.ReadOnly = true;
            this.txtTargetFolder.Size = new System.Drawing.Size(401, 20);
            this.txtTargetFolder.TabIndex = 4;
            this.txtTargetFolder.Text = "Ziel";
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSource.Location = new System.Drawing.Point(487, 16);
            this.btnSelectSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(27, 20);
            this.btnSelectSource.TabIndex = 3;
            this.btnSelectSource.Text = "...";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ziel-Ordner:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quell-Ordner:";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolder.Location = new System.Drawing.Point(83, 16);
            this.txtSourceFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.ReadOnly = true;
            this.txtSourceFolder.Size = new System.Drawing.Size(401, 20);
            this.txtSourceFolder.TabIndex = 0;
            this.txtSourceFolder.Text = "Base64";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(8, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(517, 40);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(4, 16);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(509, 15);
            this.progressBar1.TabIndex = 1;
            // 
            // btnConvertBase64ToText
            // 
            this.btnConvertBase64ToText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertBase64ToText.Location = new System.Drawing.Point(425, 133);
            this.btnConvertBase64ToText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvertBase64ToText.Name = "btnConvertBase64ToText";
            this.btnConvertBase64ToText.Size = new System.Drawing.Size(100, 26);
            this.btnConvertBase64ToText.TabIndex = 2;
            this.btnConvertBase64ToText.Text = "Konvertieren";
            this.btnConvertBase64ToText.UseVisualStyleBackColor = true;
            this.btnConvertBase64ToText.Click += new System.EventHandler(this.btnConvertBase64ToText_Click);
            // 
            // Base64Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 166);
            this.Controls.Add(this.btnConvertBase64ToText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Base64Converter";
            this.Text = "Base64 Konvertierer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectTarget;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnConvertBase64ToText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

