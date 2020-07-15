using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    internal enum AnswerType
    {
        DOGRU,
        YANLIS,
        PAS
    }
    public partial class WFGamePlay : Form
    {
        #region Properties
        string operant;
        Equation equation;
        Equation[] equations = null;
        Dictionary<Guid, AnswerType> aAndQ = new Dictionary<Guid, AnswerType>();
        int LEVEL = 0, TRUECOUNT = 0, FALSECOUNT = 0, PASCOUNT = 0;
        bool PASFLAG = false;
        #endregion

        #region Methods
        /// <summary>
        /// Default cns.
        /// </summary>
        public WFGamePlay()
        {
            InitializeComponent();
            equation = new Equation();
        }
        /// <summary>
        /// Özel bir operatör talep edilirse o operatör ile işlem yapılabilir
        /// </summary>
        /// <param name="operant">Matematiksel operatör</param>
        public WFGamePlay(string operant)
        {
            InitializeComponent();
            equation = new Equation();
            this.operant = operant;
        }



        #endregion

        #region Events
        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void WFGamePlay_Load(object sender, System.EventArgs e)
        {
            LEVEL = 1;//Seviyeyi 1 olarak tanımla
            equations = new Equation[20];
            MathGenerator mathGen = new MathGenerator();
            int levelCounter = 0;
            //20 adet soru oluştur
            for (int i = 0; i < 20; i++)
            {
                //seviyeyi testpit et
                if (i % 5 == 0)
                {
                    levelCounter++;
                }
                Equation eq = null;
                if (operant == null)
                {
                    //rassal soru oluştur
                    eq = mathGen.Equation(levelCounter);
                }
                else
                {
                    //seçilmiş matematik operatörüne ait soru oluştur
                    eq = mathGen.Equation(levelCounter, operant);
                }
                equations[i] = eq;
            }
            //Sorular için textbox kontrolleri tanımla ve forma ekle
            for (int i = 0; i < 5; i++)
            {
                Equation eq = equations[i];
                //Sorular için
                TextBox txtFunct = new TextBox()
                {
                    //Tag = eq,
                    Width = 220,
                    Font = new Font(new FontFamily("verdana"), 15),
                    Enabled = false,
                    Text = eq.ToString()
                };
                //Cevaplar için
                TextBox txtAnswer = new TextBox()
                {
                    Tag = eq,  //fonksiyon nesnesini barındırır
                    Width = 75
                };
                //Kontrolleri ekle
                flowLayoutPanel1.Controls.Add(txtFunct);
                flowLayoutPanel1.Controls.Add(txtAnswer);
            }
        }

        private void tmrCronometer_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(lblTime.Text);
            if (time==0)
            {
                MessageBox.Show("SÜRE BİTTİ");
                tmrCronometer.Stop();
                Score skor = new Score();
                skor.AddScore(string.Format("OYUN BİTTİ. SKORUN {0}", (TRUECOUNT * 30 * LEVEL) - (FALSECOUNT * 10) - (PASCOUNT * 10)));
                return;
            }
            if (TRUECOUNT>=11)
            {
                MessageBox.Show("OYUNU KAZANDINIZ.");
                Score skor = new Score();
                skor.AddScore(string.Format("OYUN BİTTİ. SKORUN {0}", (TRUECOUNT * 30 * LEVEL) - (FALSECOUNT * 10) - (PASCOUNT * 10)));
                tmrCronometer.Stop();
                return;
            }
            lblTime.Text = (time - 1).ToString();
        }

        /// <summary>
        /// Form Closed Event
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void WFGamePlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.WFMain.Show();
        }
        /// <summary>
        /// Sonraki seviyeye geç
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnNextStep_Click(object sender, System.EventArgs e)
        {

            try
            {
                int pasCounter = 0;
                foreach (TextBox item in flowLayoutPanel1.Controls)
                {
                    if (item.Tag != null)
                    {
                        if (PASFLAG == false && item.Text == "")
                        {
                            MessageBox.Show("LÜTFEN TÜM SORULARI CEVAPLAYINIZ VEYA PAS GEÇİNİZ.");
                            return;
                        }
                        //Bu bir cevaptır
                        if (((Equation)item.Tag).Calculate().ToString() == item.Text)
                        {
                            //Cevap doğrudur
                            aAndQ.Add(((Equation)item.Tag).Id, AnswerType.DOGRU);//soru doğru olarak eklenir
                        }
                        else if (item.Text == "")
                        {
                            //Cevap boştur yani pas
                            if (pasCounter != 0)
                            {
                                //Daha önce 1 defa pas geçilmiştir bu yüzden soruyu yanlış olarak işaratle
                                aAndQ.Add(((Equation)item.Tag).Id, AnswerType.YANLIS);//soru doğru olarak eklenir
                            }
                            else
                            {
                                //Daha önce pas soru yoktur
                                aAndQ.Add(((Equation)item.Tag).Id, AnswerType.PAS);//soru doğru olarak eklenir
                            }

                            pasCounter++;
                        }
                        else
                        {
                            //Cevap yanlıştır
                            aAndQ.Add(((Equation)item.Tag).Id, AnswerType.YANLIS);//soru yanlış olarak eklenir
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            PASFLAG = false;//Pas bayrağını kapat
            //Soruları tara doğru yanlış sayısını bul
            TRUECOUNT = 0; FALSECOUNT = 0; PASCOUNT = 0;
            foreach (var item in aAndQ)
            {
                if (item.Value == AnswerType.DOGRU)
                {
                    //Doğru
                    TRUECOUNT++;
                }
                else if (item.Value == AnswerType.YANLIS)
                {
                    //Yanlış
                    FALSECOUNT++;
                }
                else
                {
                    //Pas
                    PASCOUNT++;
                }
            }
            lblTrueCount.Text = TRUECOUNT.ToString();
            lblFalseCount.Text = FALSECOUNT.ToString();
            lblPasCount.Text = PASCOUNT.ToString();
            LEVEL++;//Seviye sayacını raund sonunda arttır
            lblLevelCounter.Text = string.Format("{0}. SEVİYE", LEVEL.ToString());
            if (LEVEL == 5)
            {
                //Oyun bitmiştir
                //Pas geçilmiş soru var ise
                if (PASCOUNT != 0 & (PASCOUNT + FALSECOUNT + TRUECOUNT) == 20)
                {
                    //Pas geçilmiş soru var ise             
                    flowLayoutPanel1.Controls.Clear();
                    foreach (var item in aAndQ)
                    {
                        //Pas geçilmiş bir soru ise
                        if (item.Value == AnswerType.PAS)
                        {
                            Equation eq = null;
                            //Aynı soruyu guid eşleştirmesi ile bul
                            for (int i = 0; i < 20; i++)
                            {
                                if (equations[i].Id == item.Key)
                                {
                                    //Aynı sorular ise
                                    eq = equations[i];
                                }
                            }
                            //Sorular için
                            TextBox txtFunct = new TextBox()
                            {
                                //Tag = eq,
                                Width = 220,
                                Font = new Font(new FontFamily("verdana"), 15),
                                Enabled = false,
                                Text = eq.ToString()
                            };
                            //Cevaplar için
                            TextBox txtAnswer = new TextBox()
                            {
                                Tag = eq,  //fonksiyon nesnesini barındırır
                                Width = 50
                            };
                            //Kontrolleri ekle
                            flowLayoutPanel1.Controls.Add(txtFunct);
                            flowLayoutPanel1.Controls.Add(txtAnswer);
                        }
                    }

                    lblLevelCounter.Text = "Pas Geçilen Soruları Çöz!";
                    btnPas.Enabled = false;
                    return;

                }
                else
                {
                    //Pas geçilmiş soru yok ise
                    lblLevelCounter.Text = string.Format("OYUN BİTTİ. SKORUN {0}", (TRUECOUNT * 30 * LEVEL) - (FALSECOUNT * 10) - (PASCOUNT * 10));
                    Score skor = new Score();
                    skor.AddScore(string.Format("OYUN BİTTİ. SKORUN {0}", (TRUECOUNT * 30 * LEVEL) - (FALSECOUNT * 10) - (PASCOUNT * 10)));
                    MessageBox.Show("Oyun Bitti!");
                    btnNextStep.Enabled = false;
                    btnPas.Enabled = false;
                    return;

                }


            }
            if (LEVEL > 5)
            {
                lblLevelCounter.Text = string.Format("OYUN BİTTİ. SKORUN {0}", (TRUECOUNT * 30 * LEVEL) - (FALSECOUNT * 10) - (PASCOUNT * 10));
                btnNextStep.Enabled = false;
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(new Label() {
                Text="Oyun Bitti."

                });

                Score skor = new Score();
                skor.AddScore(string.Format("OYUN BİTTİ. SKORUN {0}", (TRUECOUNT * 30 * LEVEL) - (FALSECOUNT * 10) - (PASCOUNT * 10)));
                tmrCronometer.Stop();

                return;
            }
            //Yeni sorulara yer aç
            flowLayoutPanel1.Controls.Clear();
            //Sonraki 5 soruyu getir
            for (int i = ((LEVEL * 5) - 5); i < LEVEL * 5; i++)
            {
                Equation eq = equations[i];
                //Sorular için
                TextBox txtFunct = new TextBox()
                {
                    //Tag = eq,
                    Width = 220,
                    Font = new Font(new FontFamily("verdana"), 15),
                    Enabled = false,
                    Text = eq.ToString()
                };
                //Cevaplar için
                TextBox txtAnswer = new TextBox()
                {
                    Tag = eq,  //fonksiyon nesnesini barındırır
                    Width = 50
                };
                //Kontrolleri ekle
                flowLayoutPanel1.Controls.Add(txtFunct);
                flowLayoutPanel1.Controls.Add(txtAnswer);
            }
           
        }
        /// <summary>
        /// Soruları pas geç
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPas_Click(object sender, EventArgs e)
        {
            PASFLAG = true;
            btnNextStep.PerformClick();

        }
        #endregion


    }
}
