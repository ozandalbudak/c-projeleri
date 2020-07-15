namespace UI.AdamAsmaca
{
    partial class WFMain
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtWordInput = new System.Windows.Forms.TextBox();
            this.lblAllInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.btnOpenForm = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnScor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScor)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 261);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(531, 81);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "KELİME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::UI.AdamAsmaca.Properties.Resources.exit;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(494, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtWordInput
            // 
            this.txtWordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtWordInput.Location = new System.Drawing.Point(6, 110);
            this.txtWordInput.MaxLength = 1;
            this.txtWordInput.Multiline = true;
            this.txtWordInput.Name = "txtWordInput";
            this.txtWordInput.Size = new System.Drawing.Size(47, 45);
            this.txtWordInput.TabIndex = 3;
            this.txtWordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWordInput.TextChanged += new System.EventHandler(this.txtWordInput_TextChanged);
            // 
            // lblAllInput
            // 
            this.lblAllInput.AutoSize = true;
            this.lblAllInput.BackColor = System.Drawing.Color.Transparent;
            this.lblAllInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAllInput.ForeColor = System.Drawing.Color.Green;
            this.lblAllInput.Location = new System.Drawing.Point(6, 187);
            this.lblAllInput.Name = "lblAllInput";
            this.lblAllInput.Size = new System.Drawing.Size(0, 46);
            this.lblAllInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TAHMİN";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(152, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(351, 52);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Toplam Hakkın:4";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.BackColor = System.Drawing.Color.Transparent;
            this.lblDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDown.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDown.Location = new System.Drawing.Point(333, 86);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(170, 52);
            this.lblDown.TabIndex = 7;
            this.lblDown.Text = "Kalan:2";
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenForm.BackgroundImage = global::UI.AdamAsmaca.Properties.Resources.file;
            this.btnOpenForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenForm.Location = new System.Drawing.Point(451, -1);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(37, 32);
            this.btnOpenForm.TabIndex = 8;
            this.btnOpenForm.TabStop = false;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Teal;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(0, -1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 31);
            this.lblStatus.TabIndex = 9;
            // 
            // btnScor
            // 
            this.btnScor.BackColor = System.Drawing.Color.Transparent;
            this.btnScor.BackgroundImage = global::UI.AdamAsmaca.Properties.Resources.score;
            this.btnScor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScor.Location = new System.Drawing.Point(408, -1);
            this.btnScor.Name = "btnScor";
            this.btnScor.Size = new System.Drawing.Size(37, 32);
            this.btnScor.TabIndex = 10;
            this.btnScor.TabStop = false;
            this.btnScor.Click += new System.EventHandler(this.btnScor_Click);
            // 
            // WFMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.AdamAsmaca.Properties.Resources.swish_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 342);
            this.ControlBox = false;
            this.Controls.Add(this.btnScor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOpenForm);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAllInput);
            this.Controls.Add(this.txtWordInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WFMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adam Asmaca - Mesut Pişkin 133301040";
            this.Load += new System.EventHandler(this.WFMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.TextBox txtWordInput;
        private System.Windows.Forms.Label lblAllInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.PictureBox btnOpenForm;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox btnScor;
    }
}

