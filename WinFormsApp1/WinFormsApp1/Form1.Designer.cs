namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.rdEncrypt = new System.Windows.Forms.RadioButton();
            this.rdDecrypt = new System.Windows.Forms.RadioButton();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.bttnDecrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(161, 74);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(275, 35);
            this.txtPath.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(454, 74);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(52, 40);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // rdEncrypt
            // 
            this.rdEncrypt.AutoSize = true;
            this.rdEncrypt.Location = new System.Drawing.Point(161, 127);
            this.rdEncrypt.Name = "rdEncrypt";
            this.rdEncrypt.Size = new System.Drawing.Size(107, 34);
            this.rdEncrypt.TabIndex = 2;
            this.rdEncrypt.TabStop = true;
            this.rdEncrypt.Text = "Encrypt";
            this.rdEncrypt.UseVisualStyleBackColor = true;
            this.rdEncrypt.CheckedChanged += new System.EventHandler(this.rdEncrypt_CheckedChanged);
            // 
            // rdDecrypt
            // 
            this.rdDecrypt.AutoSize = true;
            this.rdDecrypt.Location = new System.Drawing.Point(161, 167);
            this.rdDecrypt.Name = "rdDecrypt";
            this.rdDecrypt.Size = new System.Drawing.Size(110, 34);
            this.rdDecrypt.TabIndex = 3;
            this.rdDecrypt.TabStop = true;
            this.rdDecrypt.Text = "Decrypt";
            this.rdDecrypt.UseVisualStyleBackColor = true;
            this.rdDecrypt.CheckedChanged += new System.EventHandler(this.rdDecrypt_CheckedChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(161, 220);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(275, 35);
            this.txtKey.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(161, 279);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(275, 40);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 441);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.FilePath);
            this.tabPage1.Controls.Add(this.btnRun);
            this.tabPage1.Controls.Add(this.txtPath);
            this.tabPage1.Controls.Add(this.txtKey);
            this.tabPage1.Controls.Add(this.btnPath);
            this.tabPage1.Controls.Add(this.rdDecrypt);
            this.tabPage1.Controls.Add(this.rdEncrypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt a File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Key";
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Location = new System.Drawing.Point(54, 77);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(85, 30);
            this.FilePath.TabIndex = 6;
            this.FilePath.Text = "FilePath";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDecrypt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bttnDecrypt);
            this.tabPage2.Controls.Add(this.txtDecrypt);
            this.tabPage2.Controls.Add(this.txtEncrypt);
            this.tabPage2.Controls.Add(this.txtValue);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encrypt a Value";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(189, 69);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(431, 35);
            this.txtValue.TabIndex = 0;
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(189, 122);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(431, 35);
            this.txtEncrypt.TabIndex = 1;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(189, 173);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(431, 35);
            this.txtDecrypt.TabIndex = 2;
            // 
            // bttnDecrypt
            // 
            this.bttnDecrypt.Location = new System.Drawing.Point(189, 232);
            this.bttnDecrypt.Name = "bttnDecrypt";
            this.bttnDecrypt.Size = new System.Drawing.Size(431, 40);
            this.bttnDecrypt.TabIndex = 3;
            this.bttnDecrypt.Text = "Encrypt";
            this.bttnDecrypt.UseVisualStyleBackColor = true;
            this.bttnDecrypt.Click += new System.EventHandler(this.bttnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypt Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encrypted ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Decrypted";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(189, 296);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(431, 40);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 484);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtPath;
        private Button btnPath;
        private RadioButton rdEncrypt;
        private RadioButton rdDecrypt;
        private TextBox txtKey;
        private Button btnRun;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label FilePath;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button bttnDecrypt;
        private TextBox txtDecrypt;
        private TextBox txtEncrypt;
        private TextBox txtValue;
        private Button btnDecrypt;
    }
}