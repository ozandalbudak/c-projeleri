using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SayiOyunu.UI
{
    public partial class WFNumber : Form
    {
        #region Properties
        int[] dogruTahminYerleri, yanlisTahminYerleri;
        int basamakDegeri, kalanHakSayisi;
        int[] dizi, tahminEdilenDeger;
        #endregion

        #region Methods 
        public WFNumber()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Tekrarsız sayı üretmek için
        /// </summary>
        public void SayiUretTekrarsiz()
        {
            Random randomGenerator = new Random();
            dizi = new int[basamakDegeri];
            lblSelectedNumber.Text = "";


            for (int i = 0; i < basamakDegeri; i++)
            {
                dizi[i] = randomGenerator.Next(0, 10);
                if (dizi[0] == 0)
                {
                    i = -1;
                }
                for (int kontrol = 0; kontrol < i; kontrol++)
                {
                    if (dizi[kontrol] == dizi[i])
                    {
                        i--;
                        break;
                    }
                }
            }

            for (int i = 0; i < basamakDegeri; i++)
            {
                lblSelectedNumber.Text += dizi[i];
            }

        }
        /// <summary>
        /// Tekrarlı sayı üretmek için
        /// </summary>
        public void SayiUretTekrarli()
        {
            Random rnd = new Random();
            dizi = new int[basamakDegeri];
            lblSelectedNumber.Text = "";
            for (int i = 0; i < basamakDegeri; i++)
            {
                dizi[i] = rnd.Next(0, 10);
                if (dizi[0] == 0)
                {
                    i = -1;
                }
            }
            for (int i = 0; i < basamakDegeri; i++)
            {
                lblSelectedNumber.Text += dizi[i];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tmrCounter.Start();
            if (txtNumberLenght.Text == "")
            {
                MessageBox.Show("Lütfen Basamak Griniz");
                return;
            }

            basamakDegeri = int.Parse(txtNumberLenght.Text);

            if (basamakDegeri <= 1)
            {
                MessageBox.Show("En az 2 basamaklı olmak zorundadır. Lütfen Dikkatli olunuz.");
                return;
            }

            if (cmbGameType.SelectedIndex == 1)
            {
                if (basamakDegeri > 9)
                {
                    MessageBox.Show("Tekrarsız oyun için maksimum basamak dokuzdur.");
                    return;
                }
            }

            switch (cmbGameType.SelectedIndex)
            {
                case 0:
                    btnTahmin.Enabled = true;
                    txtInputNuber.Enabled = true;
                    kalanHakSayisi = basamakDegeri + 2;
                    lblKalanHak.Text = kalanHakSayisi.ToString();
                    SayiUretTekrarli();
                    break;
                case 1:
                    btnTahmin.Enabled = true;
                    txtInputNuber.Enabled = true;
                    kalanHakSayisi = basamakDegeri + 2;
                    lblKalanHak.Text = kalanHakSayisi.ToString();
                    SayiUretTekrarsiz();
                    break;
                default:
                    MessageBox.Show("Oyuna başlamadan önce bir tekrar tipi seçmek zorundasınız.");
                    return;
            }
        }
        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void SayiBul_Load(object sender, EventArgs e)
        {
            btnTahmin.Enabled = false;
            txtInputNuber.Enabled = false;
            txtResult.Enabled = false;

        }
        private void tmrCounterTick(object sender, EventArgs e)
        {
            kalanHakSayisi--;
            lblKalanHak.Text = kalanHakSayisi.ToString();
            if (kalanHakSayisi == 0)
            {
                MessageBox.Show("Oyunu Kaybettiniz.");
                txtInputNuber.Enabled = false;
                tmrCounter.Stop();
            }
            if (kalanHakSayisi < 0)
            {
                txtInputNuber.Enabled = false;
                lblKalanHak.Text = "0";
                tmrCounter.Stop();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btnShowNumber_Click(object sender, EventArgs e)
        {
            lblSelectedNumber.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (kalanHakSayisi == 0)
            {
                return;
            }
            dogruTahminYerleri = new int[basamakDegeri];
            yanlisTahminYerleri = new int[basamakDegeri];
            tmrCounter.Stop();
            tmrCounter.Interval = 7000;
            tmrCounter.Start();

            List<int> dogruKonum = new List<int>();
            List<int> yanlisKonum = new List<int>();

            txtResult.Text = "";

            if (txtInputNuber.Text == "")
            {
                MessageBox.Show("Lütfen Bir sayı giriniz!");
                return;
            }

            if (txtInputNuber.Text.Length != basamakDegeri)
            {
                MessageBox.Show("Basamak sayısı uzunluğunda sayı girmelisiniz.");
                return;
            }

            int tahminget = int.Parse(txtInputNuber.Text);

            tahminEdilenDeger = new int[basamakDegeri];
            int[] tahminters = new int[basamakDegeri];

            for (int i = 0; i < basamakDegeri; i++)
            {
                tahminEdilenDeger[i] = tahminget % 10;
                tahminget = (tahminget - tahminEdilenDeger[i]) / 10;
            }
            int a = 0;
            for (int j = basamakDegeri - 1; j >= 0; j--)
            {
                tahminters[j] = tahminEdilenDeger[a];
                a++;
            }

            for (int i = 0; i < basamakDegeri; i++)
            {
                txtResult.Text += tahminters[i];
            }

            int d = 0, y = 0;

            for (int i = 0; i < basamakDegeri; i++)
            {
                dogruTahminYerleri[i] = -1;
                yanlisTahminYerleri[i] = -1;
            }

            for (int i = 0; i < basamakDegeri; i++)
            {
                for (int j = 0; j < basamakDegeri; j++)
                {
                    if (tahminters[j] == dizi[i])
                    {
                        if (j == i)
                        {
                            dogruKonum.Add(j);
                            d++;
                            if (d == basamakDegeri)
                            {
                                try
                                {
                                    MessageBox.Show("OYUN BİTTİ SONUÇ GALİBİYET. SKORUNUZ" + kalanHakSayisi * basamakDegeri * 100);
                                    txtInputNuber.Text = "";
                                    txtResult.Text = "";
                                    txtInputNuber.Enabled = false;
                                    File.AppendAllText("SKOR.txt", string.Format("{0}{1} SKOR", kalanHakSayisi * basamakDegeri * 100 + " TARİH:" + System.DateTime.Now, Environment.NewLine));
                                    tmrCounter.Stop();
                                    kalanHakSayisi = 0;
                                    return;
                                }
                                catch (Exception ex)
                                {

                                    throw;
                                }
                            }
                        }
                        else
                        {
                            yanlisKonum.Add(j);
                            y++;
                        }
                    }
                }
            }


            foreach (int value in dogruKonum)
            {
                txtResult.SelectionStart = value;
                txtResult.SelectionLength = 1;
                txtResult.SelectionColor = Color.Blue;
            }

            foreach (int value in yanlisKonum)
            {
                txtResult.SelectionStart = value;
                txtResult.SelectionLength = 1;
                txtResult.SelectionColor = Color.Red;
            }
            kalanHakSayisi--;
            if (kalanHakSayisi == 0)
            {
                MessageBox.Show("Kaybettiniz");
                txtInputNuber.Enabled = false;
                tmrCounter.Stop();
            }
            lblKalanHak.Text = kalanHakSayisi.ToString();
        }
    }
    #endregion
}
