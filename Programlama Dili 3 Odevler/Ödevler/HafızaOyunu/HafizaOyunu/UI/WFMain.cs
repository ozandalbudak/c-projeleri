using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{

    public partial class WFMain : Form
    {
        #region Variables
        Timer timer;
        int activeImageId = 0;
        int activeSecondImageId = 0;
        byte activeUser = 1;
        Timer detectScore;
        Timer clickTimer;
        Timer closeCard;
        #endregion

        #region Methods
        public WFMain()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            detectScore = new Timer();
            detectScore.Interval = 2000;
            detectScore.Tick += DetectScore_Tick;
            clickTimer = new Timer() { Interval = 5000 };
            clickTimer.Tick += ClickTimer_Tick;
            closeCard = new Timer() { Interval = 1000 };
            closeCard.Tick += CloseCard_Tick;
        }

        /// <summary>
        /// Yanlış kart eşleştirmesi olur ise iki kartı da kapatarak değişkenleri sonraki oyuncuya set eder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCard_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox item in flowLayoutPanel.Controls)
            {
                //birinci resmi kapat
                if (item.Tag.ToString() == activeImageId.ToString())
                {
                    item.ImageLocation = "images/blocker.jpg";
                    item.Cursor = Cursors.Default;
                }
                //ikinci resmi kapat
                if (item.Tag.ToString() == activeSecondImageId.ToString())
                {
                    item.ImageLocation = "images/blocker.jpg";
                    item.Cursor = Cursors.Default;
                }

            }
            activeImageId = 0;
            activeSecondImageId = 0;
            if (activeUser == 1)
            {


                activeUser = 2;
            }
            else
            {
                //2. oyuncu aktif

                activeUser = 1;
            }
            lblInfo.Text = string.Format("Yanlış tahmin. Sırada {0}. oyuncuda.", activeUser);
            closeCard.Stop();
        }
        /// <summary>
        /// 5sn boyunca 2.karta tıklamassa kartı kapatır ve oyuncuyu değiştirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox item in flowLayoutPanel.Controls)
            {
                if (item.Tag.ToString() == activeImageId.ToString())
                {
                    item.ImageLocation = "images/blocker.jpg";
                    item.Cursor = Cursors.Default;

                }
                if (item.Tag.ToString() == activeSecondImageId.ToString())
                {
                    item.ImageLocation = "images/blocker.jpg";
                    item.Cursor = Cursors.Default;

                }
            }
            activeImageId = 0;
            activeSecondImageId = 0;
            if (activeUser == 1)
            {


                activeUser = 2;
            }
            else
            {
                //2. oyuncu aktif

                activeUser = 1;
            }
            lblInfo.Text = string.Format("Sıra {0}. oyuncuya geçti.", activeUser);
            clickTimer.Stop();
        }
        /// <summary>
        /// Kullanıcıların skorları sürekli olarak denetler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetectScore_Tick(object sender, EventArgs e)
        {

            if (Convert.ToInt32(lblUserOne.Text) == 11)
            {
                detectScore.Stop();
                flowLayoutPanel.Enabled = false;
                btnOpenCart.PerformClick();
                MessageBox.Show("TEBRİKLER 1. OYUNCU OYUNU KAZANDI.");

            }
            else if (Convert.ToInt32(lblUserTwo.Text) == 11)
            {
                detectScore.Stop();
                flowLayoutPanel.Enabled = false;
                btnOpenCart.PerformClick();
                MessageBox.Show("TEBRİKLER 2. OYUNCU OYUNU KAZANDI.");

            }
        }
        /// <summary>
        /// Başlangıçtaki 5sn lik kart açık kalma süresini denetler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            foreach (PictureBox pct in flowLayoutPanel.Controls)
            {
                pct.BackgroundImageLayout = ImageLayout.Stretch;
                pct.ImageLocation = "images/blocker.jpg";
                pct.Click += Pct_Click;
            }
            timer.Stop();
            flowLayoutPanel.Enabled = true;
            lblInfo.Text = string.Format("Oyun Başladı. Sıra {0}. Oyuncuda", activeUser);
            detectScore.Start();
        }
        private void Pct_Click(object sender, System.EventArgs e)
        {
            if (activeSecondImageId!=0 && activeImageId!=0)
            {
                //zaten seçili 2 resim mevcut
                return;
            }
            PictureBox selectedPictureBox = (PictureBox)sender;
         
            if (selectedPictureBox.ImageLocation == "images/blocker.jpg")
            {
                if (activeImageId == 0)
                {
                    selectedPictureBox.Cursor = Cursors.No;
                    selectedPictureBox.ImageLocation = string.Format("images/{0}.jpg", selectedPictureBox.Tag.ToString());
                    activeImageId = Convert.ToInt32(selectedPictureBox.Tag.ToString());
                   clickTimer.Start();
                }
                else
                {
                  
                    //ikinci kart ise işaretle
                    activeSecondImageId = Convert.ToInt32(selectedPictureBox.Tag);
                    selectedPictureBox.Cursor = Cursors.No;
                    selectedPictureBox.ImageLocation = string.Format("images/{0}.jpg", activeSecondImageId);
                    //foreach (PictureBox item in flowLayoutPanel.Controls)
                    //{
                    //    if (item.Tag.ToString()==activeSecondImageId.ToString())
                    //    {
                    //        item.ImageLocation = string.Format("images/{0}.jpg", activeSecondImageId.ToString());
                    //        flowLayoutPanel.Refresh();
                    //    }
                    //}
                    //System.Threading.Thread.Sleep(3000);
                    //Önceki kart ile karşılaştır
                    //Karşılaştırme metodu verilen bitmap nesnelerinin tüm piksellerin RGB (renk uzayı) katmanlarındaki piksel değerlerini karşılaştır ve yüzdelik olarak hesaplar ölçüm değerine göre aynı mı değilmi anlaşılabilir.
                    Bitmap img1 = new Bitmap(string.Format("images/{0}.jpg", activeImageId.ToString()));
                    Bitmap img2 = new Bitmap(string.Format("images/{0}.jpg", selectedPictureBox.Tag.ToString()));
                    if (CompareImages(img1, img2))
                    {
                        //2 görüntü aynı ise

                        if (clickTimer.Enabled)
                        {
                            //Süre bitmeden doğru cevapladısa timeri durdur
                            clickTimer.Stop();
                        }
                        //resimler aynı
                        lblInfo.Text = "Tebrikler doğru tahmin. Devam...";
                        if (activeUser == 1)
                        {
                            lblUserOne.Text = Convert.ToInt32(lblUserOne.Text) + 1 + "";
                        }
                        else
                        {
                            //2. oyuncu aktif
                            lblUserTwo.Text = Convert.ToInt32(lblUserTwo.Text) + 1 + "";
                        }
                        foreach (PictureBox item in flowLayoutPanel.Controls)
                        {
                            if (item.Tag.ToString() == activeImageId.ToString() || item.Tag == selectedPictureBox.Tag)
                            {
                                item.Enabled = false;
                                item.Cursor = Cursors.No;
                                item.ImageLocation = "images/ok.jpg";
                                
                                //item.Image = DrawTextOmBitmap(new Bitmap("images/ok.jpg"), activeUser.ToString());
                            }

                        }
                        selectedPictureBox.Image = img2;
                        activeImageId = 0;
                        activeSecondImageId = 0;
                    }
                    else
                    {
                        //yanlış eşleştirme
                        //Diğer kullanıcıya geç

                        closeCard.Start();

                    }
                }
            }
        }
        private void WFMain_Load(object sender, System.EventArgs e)
        {
            labelUserOneName.Text = Program.FIRSTUSERNAME;
            lblUserTwoName.Text = Program.SECONDUSER;
            flowLayoutPanel.Enabled = false;
            for (int i = 1; i <= 40; i++)
            {
                PictureBox imageBox = new PictureBox()
                {
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ImageLocation = string.Format("images/{0}.jpg", i),
                    Width = 130,
                    Height = 115,
                    Tag = i.ToString(),
                    Cursor = Cursors.Hand

                };
                flowLayoutPanel.Controls.Add(imageBox);
            }
            timer.Start();
            lblInfo.Text = "5 saniye içerisinde kartlar kapanacak.";
        }
        private bool CompareImages(Bitmap img1, Bitmap img2)
        {
            if (img1.Size != img2.Size)
            {
                Console.Error.WriteLine("Resim boyutu farklı");
                return false;
            }
            float fark = 0;
            for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    fark += (float)Math.Abs(img1.GetPixel(x, y).R - img2.GetPixel(x, y).R) / 255;
                    fark += (float)Math.Abs(img1.GetPixel(x, y).G - img2.GetPixel(x, y).G) / 255;
                    fark += (float)Math.Abs(img1.GetPixel(x, y).B - img2.GetPixel(x, y).B) / 255;
                }
            }
            if ((100 * fark / (img1.Width * img1.Height * 3)) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnOpenCart_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Enabled = false;
            int i = 1;
            foreach (PictureBox pct in flowLayoutPanel.Controls)
            {
                pct.BackgroundImageLayout = ImageLayout.Stretch;
                pct.ImageLocation = string.Format("images/{0}.jpg", i);
                i++;

            }


        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {

            Application.Restart();
            Environment.Exit(0);
        }
        /// <summary>
        /// İstenilen bitmap üzerine text ekler
        /// </summary>
        /// <param name="b">Eski bitmap</param>
        /// <param name="text">Yazılacak metin</param>
        /// <returns></returns>
        private Bitmap DrawTextOmBitmap(Bitmap b,string text)
        {
            float y =  50;
            float x =  50;
            RectangleF r = new RectangleF(x, y, 0, 0);
            Graphics g = Graphics.FromImage(b);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.DrawString(text, new Font("Thaoma", 25), Brushes.Black, r);

            g.Flush();

            return b;

        }
        #endregion
    }
}
