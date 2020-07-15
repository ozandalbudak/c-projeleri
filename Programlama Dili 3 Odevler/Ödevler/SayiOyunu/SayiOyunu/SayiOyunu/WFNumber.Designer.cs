namespace SayiOyunu.UI
{
    partial class WFNumber
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
            this.components = new System.ComponentModel.Container();
            this.lblBasamakSayi = new System.Windows.Forms.Label();
            this.lblTekrarSeçeneği = new System.Windows.Forms.Label();
            this.txtNumberLenght = new System.Windows.Forms.TextBox();
            this.cmbGameType = new System.Windows.Forms.ComboBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtInputNuber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSecenekler = new System.Windows.Forms.GroupBox();
            this.groupBoxTahmin = new System.Windows.Forms.GroupBox();
            this.groupBoxSonuc = new System.Windows.Forms.GroupBox();
            this.lblSelectedNumber = new System.Windows.Forms.Label();
            this.btnShowNumber = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBoxSecenekler.SuspendLayout();
            this.groupBoxTahmin.SuspendLayout();
            this.groupBoxSonuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBasamakSayi
            // 
            this.lblBasamakSayi.AutoSize = true;
            this.lblBasamakSayi.Location = new System.Drawing.Point(10, 21);
            this.lblBasamakSayi.Name = "lblBasamakSayi";
            this.lblBasamakSayi.Size = new System.Drawing.Size(84, 13);
            this.lblBasamakSayi.TabIndex = 0;
            this.lblBasamakSayi.Text = "Basamak Sayısı:";
            // 
            // lblTekrarSeçeneği
            // 
            this.lblTekrarSeçeneği.AutoSize = true;
            this.lblTekrarSeçeneği.Location = new System.Drawing.Point(13, 53);
            this.lblTekrarSeçeneği.Name = "lblTekrarSeçeneği";
            this.lblTekrarSeçeneği.Size = new System.Drawing.Size(81, 13);
            this.lblTekrarSeçeneği.TabIndex = 1;
            this.lblTekrarSeçeneği.Text = "Tekrar Durumu:";
            // 
            // txtNumberLenght
            // 
            this.txtNumberLenght.Location = new System.Drawing.Point(100, 19);
            this.txtNumberLenght.Name = "txtNumberLenght";
            this.txtNumberLenght.Size = new System.Drawing.Size(100, 20);
            this.txtNumberLenght.TabIndex = 2;
            this.txtNumberLenght.Text = "0";
            this.txtNumberLenght.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // cmbGameType
            // 
            this.cmbGameType.FormattingEnabled = true;
            this.cmbGameType.Items.AddRange(new object[] {
            "Tekrarlı",
            "Tekrarsız"});
            this.cmbGameType.Location = new System.Drawing.Point(99, 50);
            this.cmbGameType.Name = "cmbGameType";
            this.cmbGameType.Size = new System.Drawing.Size(101, 21);
            this.cmbGameType.TabIndex = 3;
            this.cmbGameType.Text = "Seçiniz";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.Location = new System.Drawing.Point(9, 84);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(197, 23);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "OYUNU BAŞLAT";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInputNuber
            // 
            this.txtInputNuber.Location = new System.Drawing.Point(6, 46);
            this.txtInputNuber.Name = "txtInputNuber";
            this.txtInputNuber.Size = new System.Drawing.Size(178, 20);
            this.txtInputNuber.TabIndex = 5;
            this.txtInputNuber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tahmininizi Giriniz";
            // 
            // btnTahmin
            // 
            this.btnTahmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTahmin.Location = new System.Drawing.Point(6, 84);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(178, 23);
            this.btnTahmin.TabIndex = 7;
            this.btnTahmin.Text = "TAHMİNİ GİR";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.Location = new System.Drawing.Point(9, 20);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(77, 24);
            this.lblHak.TabIndex = 8;
            this.lblHak.Text = "Hakkın :";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanHak.ForeColor = System.Drawing.Color.Red;
            this.lblKalanHak.Location = new System.Drawing.Point(87, 21);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(20, 24);
            this.lblKalanHak.TabIndex = 10;
            this.lblKalanHak.Text = "0";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.Location = new System.Drawing.Point(9, 63);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(191, 31);
            this.txtResult.TabIndex = 11;
            this.txtResult.Text = "";
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 7000;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounterTick);
            // 
            // groupBoxSecenekler
            // 
            this.groupBoxSecenekler.Controls.Add(this.lblTekrarSeçeneği);
            this.groupBoxSecenekler.Controls.Add(this.lblBasamakSayi);
            this.groupBoxSecenekler.Controls.Add(this.txtNumberLenght);
            this.groupBoxSecenekler.Controls.Add(this.cmbGameType);
            this.groupBoxSecenekler.Controls.Add(this.btnStartGame);
            this.groupBoxSecenekler.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSecenekler.Name = "groupBoxSecenekler";
            this.groupBoxSecenekler.Size = new System.Drawing.Size(211, 113);
            this.groupBoxSecenekler.TabIndex = 13;
            this.groupBoxSecenekler.TabStop = false;
            this.groupBoxSecenekler.Text = "Seçenekler";
            // 
            // groupBoxTahmin
            // 
            this.groupBoxTahmin.Controls.Add(this.txtInputNuber);
            this.groupBoxTahmin.Controls.Add(this.btnTahmin);
            this.groupBoxTahmin.Controls.Add(this.label3);
            this.groupBoxTahmin.Location = new System.Drawing.Point(229, 12);
            this.groupBoxTahmin.Name = "groupBoxTahmin";
            this.groupBoxTahmin.Size = new System.Drawing.Size(190, 113);
            this.groupBoxTahmin.TabIndex = 14;
            this.groupBoxTahmin.TabStop = false;
            this.groupBoxTahmin.Text = "Tahmin";
            // 
            // groupBoxSonuc
            // 
            this.groupBoxSonuc.Controls.Add(this.lblHak);
            this.groupBoxSonuc.Controls.Add(this.lblKalanHak);
            this.groupBoxSonuc.Controls.Add(this.txtResult);
            this.groupBoxSonuc.Location = new System.Drawing.Point(12, 131);
            this.groupBoxSonuc.Name = "groupBoxSonuc";
            this.groupBoxSonuc.Size = new System.Drawing.Size(211, 100);
            this.groupBoxSonuc.TabIndex = 15;
            this.groupBoxSonuc.TabStop = false;
            this.groupBoxSonuc.Text = "Sonuç";
            // 
            // lblSelectedNumber
            // 
            this.lblSelectedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectedNumber.ForeColor = System.Drawing.Color.Red;
            this.lblSelectedNumber.Location = new System.Drawing.Point(248, 141);
            this.lblSelectedNumber.Name = "lblSelectedNumber";
            this.lblSelectedNumber.Size = new System.Drawing.Size(153, 35);
            this.lblSelectedNumber.TabIndex = 9;
            this.lblSelectedNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelectedNumber.Visible = false;
            // 
            // btnShowNumber
            // 
            this.btnShowNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNumber.Location = new System.Drawing.Point(238, 190);
            this.btnShowNumber.Name = "btnShowNumber";
            this.btnShowNumber.Size = new System.Drawing.Size(65, 41);
            this.btnShowNumber.TabIndex = 16;
            this.btnShowNumber.Text = "GÖSTER";
            this.btnShowNumber.UseVisualStyleBackColor = true;
            this.btnShowNumber.Click += new System.EventHandler(this.btnShowNumber_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(374, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 41);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Location = new System.Drawing.Point(309, 190);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(59, 41);
            this.btnRestart.TabIndex = 18;
            this.btnRestart.Text = "YENİ";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click_1);
            // 
            // WFNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 243);
            this.ControlBox = false;
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowNumber);
            this.Controls.Add(this.groupBoxSonuc);
            this.Controls.Add(this.groupBoxTahmin);
            this.Controls.Add(this.groupBoxSecenekler);
            this.Controls.Add(this.lblSelectedNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WFNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayi Oyunu Mesut Pişkin 133301040";
            this.Load += new System.EventHandler(this.SayiBul_Load);
            this.groupBoxSecenekler.ResumeLayout(false);
            this.groupBoxSecenekler.PerformLayout();
            this.groupBoxTahmin.ResumeLayout(false);
            this.groupBoxTahmin.PerformLayout();
            this.groupBoxSonuc.ResumeLayout(false);
            this.groupBoxSonuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBasamakSayi;
        private System.Windows.Forms.Label lblTekrarSeçeneği;
        private System.Windows.Forms.TextBox txtNumberLenght;
        private System.Windows.Forms.ComboBox cmbGameType;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtInputNuber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.GroupBox groupBoxSecenekler;
        private System.Windows.Forms.GroupBox groupBoxTahmin;
        private System.Windows.Forms.GroupBox groupBoxSonuc;
        private System.Windows.Forms.Label lblSelectedNumber;
        private System.Windows.Forms.Button btnShowNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
    }
}