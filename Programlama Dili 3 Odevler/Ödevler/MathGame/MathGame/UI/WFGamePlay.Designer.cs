namespace UI
{
    partial class WFGamePlay
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnPas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPasCount = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFalseCount = new System.Windows.Forms.LinkLabel();
            this.lblTrueCount = new System.Windows.Forms.LinkLabel();
            this.lblTotalFalseCount = new System.Windows.Forms.Label();
            this.lblTotalTrueCount = new System.Windows.Forms.Label();
            this.lblLevelCounter = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrCronometer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 323);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextStep.ForeColor = System.Drawing.Color.Green;
            this.btnNextStep.Location = new System.Drawing.Point(247, 398);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(229, 53);
            this.btnNextStep.TabIndex = 1;
            this.btnNextStep.Text = "İLERİ";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnPas
            // 
            this.btnPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPas.Location = new System.Drawing.Point(12, 398);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(229, 53);
            this.btnPas.TabIndex = 2;
            this.btnPas.Text = "PAS";
            this.btnPas.UseVisualStyleBackColor = true;
            this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPasCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFalseCount);
            this.groupBox1.Controls.Add(this.lblTrueCount);
            this.groupBox1.Controls.Add(this.lblTotalFalseCount);
            this.groupBox1.Controls.Add(this.lblTotalTrueCount);
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatistikler";
            // 
            // lblPasCount
            // 
            this.lblPasCount.AutoSize = true;
            this.lblPasCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasCount.Location = new System.Drawing.Point(183, 67);
            this.lblPasCount.Name = "lblPasCount";
            this.lblPasCount.Size = new System.Drawing.Size(18, 20);
            this.lblPasCount.TabIndex = 5;
            this.lblPasCount.TabStop = true;
            this.lblPasCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(88, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "PAS SAYISI:";
            // 
            // lblFalseCount
            // 
            this.lblFalseCount.AutoSize = true;
            this.lblFalseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFalseCount.Location = new System.Drawing.Point(183, 42);
            this.lblFalseCount.Name = "lblFalseCount";
            this.lblFalseCount.Size = new System.Drawing.Size(18, 20);
            this.lblFalseCount.TabIndex = 3;
            this.lblFalseCount.TabStop = true;
            this.lblFalseCount.Text = "0";
            // 
            // lblTrueCount
            // 
            this.lblTrueCount.AutoSize = true;
            this.lblTrueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTrueCount.Location = new System.Drawing.Point(183, 19);
            this.lblTrueCount.Name = "lblTrueCount";
            this.lblTrueCount.Size = new System.Drawing.Size(18, 20);
            this.lblTrueCount.TabIndex = 2;
            this.lblTrueCount.TabStop = true;
            this.lblTrueCount.Text = "0";
            // 
            // lblTotalFalseCount
            // 
            this.lblTotalFalseCount.AutoSize = true;
            this.lblTotalFalseCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalFalseCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalFalseCount.Location = new System.Drawing.Point(8, 46);
            this.lblTotalFalseCount.Name = "lblTotalFalseCount";
            this.lblTotalFalseCount.Size = new System.Drawing.Size(170, 16);
            this.lblTotalFalseCount.TabIndex = 1;
            this.lblTotalFalseCount.Text = "TOPLAM YANLIŞ SAYISI:";
            // 
            // lblTotalTrueCount
            // 
            this.lblTotalTrueCount.AutoSize = true;
            this.lblTotalTrueCount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTrueCount.ForeColor = System.Drawing.Color.Green;
            this.lblTotalTrueCount.Location = new System.Drawing.Point(10, 23);
            this.lblTotalTrueCount.Name = "lblTotalTrueCount";
            this.lblTotalTrueCount.Size = new System.Drawing.Size(168, 16);
            this.lblTotalTrueCount.TabIndex = 0;
            this.lblTotalTrueCount.Text = "TOPLAM DOĞRU SAYISI:";
            // 
            // lblLevelCounter
            // 
            this.lblLevelCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblLevelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLevelCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLevelCounter.Location = new System.Drawing.Point(12, 351);
            this.lblLevelCounter.Name = "lblLevelCounter";
            this.lblLevelCounter.Size = new System.Drawing.Size(464, 34);
            this.lblLevelCounter.TabIndex = 4;
            this.lblLevelCounter.Text = "1. SEVİYE";
            this.lblLevelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTime.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTime.Location = new System.Drawing.Point(298, 176);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(130, 86);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "500";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(299, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kalan Süre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCronometer
            // 
            this.tmrCronometer.Enabled = true;
            this.tmrCronometer.Interval = 1000;
            this.tmrCronometer.Tick += new System.EventHandler(this.tmrCronometer_Tick);
            // 
            // WFGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLevelCounter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPas);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WFGamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesut Pişkin 133301040";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WFGamePlay_FormClosed);
            this.Load += new System.EventHandler(this.WFGamePlay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnPas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalFalseCount;
        private System.Windows.Forms.Label lblTotalTrueCount;
        private System.Windows.Forms.LinkLabel lblFalseCount;
        private System.Windows.Forms.LinkLabel lblTrueCount;
        private System.Windows.Forms.LinkLabel lblPasCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevelCounter;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrCronometer;
    }
}