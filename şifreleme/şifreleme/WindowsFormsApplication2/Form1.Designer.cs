namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.btnChangeEncrypt = new System.Windows.Forms.Button();
            this.txtDestinationEncrypt = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtConPassEncrypt = new System.Windows.Forms.TextBox();
            this.txtPassEncrypt = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnBrowseEncrypt = new System.Windows.Forms.Button();
            this.txtFileToEncrypt = new System.Windows.Forms.TextBox();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.btnChangeDecrypt = new System.Windows.Forms.Button();
            this.txtDestinationDecrypt = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtConPassDecrypt = new System.Windows.Forms.TextBox();
            this.txtPassDecrypt = new System.Windows.Forms.TextBox();
            this.btnBrowseDecrypt = new System.Windows.Forms.Button();
            this.txtFileToDecrypt = new System.Windows.Forms.TextBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage1.Controls.Add(this.btnChangeEncrypt);
            this.TabPage1.Controls.Add(this.txtDestinationEncrypt);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.btnEncrypt);
            this.TabPage1.Controls.Add(this.txtConPassEncrypt);
            this.TabPage1.Controls.Add(this.txtPassEncrypt);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.btnBrowseEncrypt);
            this.TabPage1.Controls.Add(this.txtFileToEncrypt);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(376, 119);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "DOSYA ŞİFRELEME";
            // 
            // btnChangeEncrypt
            // 
            this.btnChangeEncrypt.Enabled = false;
            this.btnChangeEncrypt.Location = new System.Drawing.Point(296, 32);
            this.btnChangeEncrypt.Name = "btnChangeEncrypt";
            this.btnChangeEncrypt.Size = new System.Drawing.Size(72, 21);
            this.btnChangeEncrypt.TabIndex = 11;
            this.btnChangeEncrypt.Text = "DEĞİŞTİR";
            this.btnChangeEncrypt.Click += new System.EventHandler(this.btnChangeEncrypt_Click);
            // 
            // txtDestinationEncrypt
            // 
            this.txtDestinationEncrypt.Location = new System.Drawing.Point(104, 32);
            this.txtDestinationEncrypt.Name = "txtDestinationEncrypt";
            this.txtDestinationEncrypt.ReadOnly = true;
            this.txtDestinationEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtDestinationEncrypt.TabIndex = 10;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(8, 32);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 16);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Hedaf kaynak";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(296, 72);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(72, 32);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "ŞİFRELE";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtConPassEncrypt
            // 
            this.txtConPassEncrypt.Location = new System.Drawing.Point(104, 88);
            this.txtConPassEncrypt.Name = "txtConPassEncrypt";
            this.txtConPassEncrypt.PasswordChar = '*';
            this.txtConPassEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtConPassEncrypt.TabIndex = 7;
            // 
            // txtPassEncrypt
            // 
            this.txtPassEncrypt.Location = new System.Drawing.Point(104, 64);
            this.txtPassEncrypt.Name = "txtPassEncrypt";
            this.txtPassEncrypt.PasswordChar = '*';
            this.txtPassEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtPassEncrypt.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Şifrelenecek dosya";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(-8, 88);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "yeniden şifreyi girin";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "şifreyi giriniz";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowseEncrypt
            // 
            this.btnBrowseEncrypt.Location = new System.Drawing.Point(296, 8);
            this.btnBrowseEncrypt.Name = "btnBrowseEncrypt";
            this.btnBrowseEncrypt.Size = new System.Drawing.Size(72, 21);
            this.btnBrowseEncrypt.TabIndex = 2;
            this.btnBrowseEncrypt.Text = "GÖZAT";
            this.btnBrowseEncrypt.Click += new System.EventHandler(this.btnBrowseEncrypt_Click);
            // 
            // txtFileToEncrypt
            // 
            this.txtFileToEncrypt.Location = new System.Drawing.Point(104, 8);
            this.txtFileToEncrypt.Name = "txtFileToEncrypt";
            this.txtFileToEncrypt.ReadOnly = true;
            this.txtFileToEncrypt.Size = new System.Drawing.Size(184, 20);
            this.txtFileToEncrypt.TabIndex = 1;
            this.txtFileToEncrypt.Text = "\r\nDosyayı yüklemek için Gözat\'ı tıklayın.";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(2, 144);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(380, 18);
            this.pbStatus.TabIndex = 3;
            // 
            // btnChangeDecrypt
            // 
            this.btnChangeDecrypt.Enabled = false;
            this.btnChangeDecrypt.Location = new System.Drawing.Point(296, 32);
            this.btnChangeDecrypt.Name = "btnChangeDecrypt";
            this.btnChangeDecrypt.Size = new System.Drawing.Size(72, 21);
            this.btnChangeDecrypt.TabIndex = 22;
            this.btnChangeDecrypt.Text = "DEĞİŞTİR";
            this.btnChangeDecrypt.Click += new System.EventHandler(this.btnChangeDecrypt_Click);
            // 
            // txtDestinationDecrypt
            // 
            this.txtDestinationDecrypt.Location = new System.Drawing.Point(104, 32);
            this.txtDestinationDecrypt.Name = "txtDestinationDecrypt";
            this.txtDestinationDecrypt.ReadOnly = true;
            this.txtDestinationDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtDestinationDecrypt.TabIndex = 21;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(296, 72);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(72, 32);
            this.btnDecrypt.TabIndex = 19;
            this.btnDecrypt.Text = "ÇÖZ";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtConPassDecrypt
            // 
            this.txtConPassDecrypt.Location = new System.Drawing.Point(104, 88);
            this.txtConPassDecrypt.Name = "txtConPassDecrypt";
            this.txtConPassDecrypt.PasswordChar = '*';
            this.txtConPassDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtConPassDecrypt.TabIndex = 18;
            // 
            // txtPassDecrypt
            // 
            this.txtPassDecrypt.Location = new System.Drawing.Point(104, 64);
            this.txtPassDecrypt.Name = "txtPassDecrypt";
            this.txtPassDecrypt.PasswordChar = '*';
            this.txtPassDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtPassDecrypt.TabIndex = 17;
            // 
            // btnBrowseDecrypt
            // 
            this.btnBrowseDecrypt.Location = new System.Drawing.Point(296, 8);
            this.btnBrowseDecrypt.Name = "btnBrowseDecrypt";
            this.btnBrowseDecrypt.Size = new System.Drawing.Size(72, 21);
            this.btnBrowseDecrypt.TabIndex = 13;
            this.btnBrowseDecrypt.Text = "GÖZAT";
            this.btnBrowseDecrypt.Click += new System.EventHandler(this.btnBrowseDecrypt_Click);
            // 
            // txtFileToDecrypt
            // 
            this.txtFileToDecrypt.Location = new System.Drawing.Point(104, 8);
            this.txtFileToDecrypt.Name = "txtFileToDecrypt";
            this.txtFileToDecrypt.ReadOnly = true;
            this.txtFileToDecrypt.Size = new System.Drawing.Size(184, 20);
            this.txtFileToDecrypt.TabIndex = 12;
            this.txtFileToDecrypt.Text = "\r\nDosyayı yüklemek için Gözat\'ı tıklayın.";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.label5);
            this.TabPage2.Controls.Add(this.label6);
            this.TabPage2.Controls.Add(this.label7);
            this.TabPage2.Controls.Add(this.label8);
            this.TabPage2.Controls.Add(this.btnChangeDecrypt);
            this.TabPage2.Controls.Add(this.txtDestinationDecrypt);
            this.TabPage2.Controls.Add(this.btnDecrypt);
            this.TabPage2.Controls.Add(this.txtConPassDecrypt);
            this.TabPage2.Controls.Add(this.txtPassDecrypt);
            this.TabPage2.Controls.Add(this.btnBrowseDecrypt);
            this.TabPage2.Controls.Add(this.txtFileToDecrypt);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(376, 119);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "DOSYAYI ÇÖZ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hedaf kaynak";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "ÇÖZÜLECEK DOSYA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-6, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "yeniden şifreyi girin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "şifreyi giriniz";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(2, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(384, 145);
            this.TabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 164);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ProgressBar pbStatus;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TabPage TabPage1;
        public System.Windows.Forms.Button btnChangeEncrypt;
        public System.Windows.Forms.TextBox txtDestinationEncrypt;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Button btnEncrypt;
        public System.Windows.Forms.TextBox txtConPassEncrypt;
        public System.Windows.Forms.TextBox txtPassEncrypt;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Button btnBrowseEncrypt;
        public System.Windows.Forms.TextBox txtFileToEncrypt;
        public System.Windows.Forms.Button btnChangeDecrypt;
        public System.Windows.Forms.TextBox txtDestinationDecrypt;
        public System.Windows.Forms.Button btnDecrypt;
        public System.Windows.Forms.TextBox txtConPassDecrypt;
        public System.Windows.Forms.TextBox txtPassDecrypt;
        public System.Windows.Forms.Button btnBrowseDecrypt;
        public System.Windows.Forms.TextBox txtFileToDecrypt;
        public System.Windows.Forms.TabPage TabPage2;
        public System.Windows.Forms.TabControl TabControl1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
    }
}

