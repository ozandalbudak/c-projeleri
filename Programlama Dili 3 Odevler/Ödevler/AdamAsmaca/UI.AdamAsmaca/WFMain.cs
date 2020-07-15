using System;
using System.Windows.Forms;
using MODEL.AdamAsmaca;
namespace UI.AdamAsmaca
{
    public partial class WFMain : Form
    {
        #region Variable
        private int total = 0, down = 0;
        private int defaultCount = 5;
        string selectedKeyword;
        private Score score = null;
        #endregion

        public WFMain()
        {
            InitializeComponent();
            score = Program.SCORE;
        }

        #region Methods
        private void WFMain_Load(object sender, EventArgs e)
        {
            Keyword keyword = Program.KEYWORD;
            try
            {
                selectedKeyword = keyword.GetKeyword(Program.WORDLENGHT).ToUpper();
            }
            catch
            {

                MessageBox.Show(String.Format("{0} karakterlik kelime bulunumadı. Bunun yerine {1} karakterlik kelime yüklendi.", Program.WORDLENGHT, defaultCount));
                selectedKeyword = keyword.GetKeyword(defaultCount).ToUpper();
                Program.WORDLENGHT = defaultCount;
            }
            for (int i = 0; i < Program.WORDLENGHT; i++)
            {
                TextBox txtWordInput = new TextBox()
                {
                    Tag = i,
                    Width = 50,
                    ForeColor = System.Drawing.Color.Red,
                    Enabled = false
                };
                flowLayoutPanel.Controls.Add(txtWordInput);
            }
            total = Program.WORDLENGHT * 2;
            down = Program.WORDLENGHT * 2;
            lblTotal.Text = String.Format("Toplam Hakkın:{0}", total);
            lblDown.Text = String.Format("Kalan:{0}", down);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtWordInput_TextChanged(object sender, EventArgs e)
        {

            string input = txtWordInput.Text.ToUpper();
            if (input == null || input == "")
            {
                return;
            }
            for (int i = 0; i < lblAllInput.Text.Length; i++)
            {
                if (lblAllInput.Text[i].ToString() == input)
                {
                    VibrationForm();
                    return;

                }
            }
            int x = 0, y = 0;
            foreach (char item in selectedKeyword.ToCharArray())
            {
                if (item.ToString() == input)
                {
                    foreach (TextBox txtALFP in flowLayoutPanel.Controls)
                    {
                        if (txtALFP.Tag.ToString() == x.ToString())
                        {
                            txtALFP.Text = item.ToString();
                        }
                    }
                    y++;
                }

                x++;
            }

            if (y == 0)
            {
                lblAllInput.Text += txtWordInput.Text.ToUpper();
            }
            CheckStatus(down);

            down--;


        }

        private void CheckStatus(int status)
        {

            if (status == 0)
            {
                int i = 0;
                foreach (TextBox item in flowLayoutPanel.Controls)
                {
                    item.Text = selectedKeyword.ToCharArray()[i].ToString();
                    i++;
                }
                lblStatus.Text = "OYUNU KAYBETTİN";
                score.AddScore("YENİLGİ SKOR:-" + selectedKeyword.Length * 100);
                this.Text = "YENİLGİ SKOR:-" + selectedKeyword.Length * 100;
                txtWordInput.Enabled = false;
                VibrationForm();
            }
            if (down != 0)
            {
                int counter = 0;
                foreach (TextBox item in flowLayoutPanel.Controls)
                {
                    if (item.Text == "")
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    lblStatus.Text = "OYUNU KAZANDIN";
                    score.AddScore("GALİBİYET SKOR:" + down * 100);
                    this.Text = "GALİBİYET SKOR:" + down * 100;
                    txtWordInput.Enabled = false;
                    VibrationForm();
                }
            }

            lblDown.Text = String.Format("Kalan:{0}", status);
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            WFSettings settingsForm = new WFSettings();
            settingsForm.ShowDialog();
        }

        private void btnScor_Click(object sender, EventArgs e)
        {
            WFScoreList settingsForm = new WFScoreList();
            settingsForm.ShowDialog();
        }

        private void VibrationForm()
        {
            for (int i = 0; i < 300; i++)
            {
                this.Top += 5;
                this.Left += 5;
                this.Top -= 5;
                this.Left -= 5;
                i++;
            }
        }
        #endregion
    }
}
