using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace WindowsFormsApplication2
{
    enum Sifreleme {
        sifrele = 1,
        coz = 2
    }
                
    public partial class Form1 : Form
    {
       
        FileStream giris;
        FileStream cikis;
        SHA512Managed SHA512 = new SHA512Managed();
         string gsdosyayolu = null, sscdosyayolu = null, gscdosyayolu = null, ssdosyayolu = null;
         public Form1()
        {
            InitializeComponent();
        }
        
        private byte[] anahtaryarat(string strPassword)
        {
            //parolayı cahr dizisine çevrildi
            char[] chrData = strPassword.ToCharArray();
            //şifrenin uzunluğunu alındı.
            int intLength = chrData.GetUpperBound(0);
            // bytDataToHash öğesini bildirin ve chrDatadan bir fazla yapıldı.
            byte[] bytDataToHash = new byte[intLength + 1];

            //chrData'yı bytDataToHash'a dönüştürmek ve saklamak için Next'e For Use.
            for (int i = 0; i <= intLength; i++)
            {
                bytDataToHash[i] = Convert.ToByte((int)(chrData[i]));
            }

            // BytResult, Hash bytDataToHash'ı bildirin ve bytResult dosyasında saklayın.
            byte[] bytResult = SHA512.ComputeHash(bytDataToHash);
            //BytKey'i bildir (31). 256 bit tutacak.
            byte[] bytKey = new byte[32];


            // Belirli bir boyutu (256 bit) koymak için Next'e For Use
            // bytResult bytKey'e. 0 ila 31, ilk 256 biti
            // 512 bitten bytKey'e.
            for (int i = 0; i <= 31; i++)
            {
                bytKey[i] = bytResult[i];
            }

            return bytKey;
            //anahtarı döndür
        }
       private byte[] anahtar2yarat(string strPassword)
        {
            // StrPassword öğesini bir diziye dönüştürür ve chrData'da depolar.
            char[] chrData = strPassword.ToCharArray();
            // strPassword boyutunu elde etmek için intLength kullanın.
            int intLength = chrData.GetUpperBound(0);
            // bytDataToHash öğesini bildirin ve chrData ile aynı boyutta yapın.
            byte[] bytDataToHash = new byte[intLength + 1];
            // chrData'yı bytDataToHash'a dönüştürmek ve depolamak için Next'e (Sonraki) için kullanın.
            for (int i = 0; i <= chrData.GetUpperBound(0); i++)
            {
                bytDataToHash[i] = Convert.ToByte((int)(chrData[i]));
            }


            // Hangi karmanın kullanılacağını bildirin.

            // BytResult, Hash bytDataToHash'ı bildirin ve bytResult dosyasında saklayın.
            byte[] sonuc = SHA512.ComputeHash(bytDataToHash);

            // anahtar2'yi bildirin (15). 128 bit tutar.
            byte[] anahtar2 = new byte[16];


            // Belirli bir boyutu (128 bit) koymak için Next'e For Use
            // bytResult bytIV'ye. BytKey için 0 ila 30, ilk 256 biti kullandı.
            // karışık parolanın. 32 ila 47, sonraki 128 biti byIV'ye yerleştirecektir.
            for (int i = 32; i <= 47; i++)
            {
                anahtar2[i - 32] = sonuc[i];
            }

            return anahtar2;
            //anahtar 2 yi döndür
        }
        private void dosyasifreleyadacoz(string sifrelenecekdosya, string sifrelenendosya, byte[] bytKey, byte[] bytIV, Sifreleme Direction)
        {
            //hata durumunda ise
            try
            {
                //Giriş ve çıkışı işlemek için dosya akışları ayarlayın.
                giris = new FileStream(sifrelenecekdosya, FileMode.Open, FileAccess.Read);
                cikis = new FileStream(sifrelenendosya, FileMode.OpenOrCreate, FileAccess.Write);
                cikis.SetLength(0);
                //cikis öğesinin boş olduğundan emin olun

                //Şifreleme / şifre çözme işlemi için değişkenleri bildirin.
                byte[] bytBuffer = new byte[4097];
                //Işleme için bir bayt bloğu tutar.
                long lngBytesProcessed = 0;
                //Işlenmiş baytların sayısı
                long lngFileLength = giris.Length;
                //Giriş dosyası uzunluğu
                int intBytesInCurrentBlock = 0;
                //Geçerli bayt işleniyor
                CryptoStream csCryptoStream = null;
                //CryptoServiceProvider'ı bildirin.
                RijndaelManaged cspRijndael = new RijndaelManaged();
                //Kurulum İlerleme Çubuğu
               pbStatus.Value = 0;
               pbStatus.Maximum = 100;

                //Şifreleme veya şifre çözme olup olmadığını belirleyin ve CryptoStream'i kurun.
                switch (Direction)
                {
                    case Sifreleme.sifrele:
                        csCryptoStream = new CryptoStream(cikis, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);

                        break;
                    case Sifreleme.coz:
                        csCryptoStream = new CryptoStream(cikis, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
                        break;
                }


                // Dosyanın tamamı işlenene kadar While işlevini kullanın.
                while (lngBytesProcessed < lngFileLength)
                {

                    // Dosyayı, giriş dosya akımı ile birlikte okuyun.
                    intBytesInCurrentBlock = giris.Read(bytBuffer, 0, 4096);

                    // Çıktı dosyasını kriptostream ile yaz.
                    csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock);
                    //Update lngBytesProcessed
                    lngBytesProcessed = lngBytesProcessed + Convert.ToInt64(intBytesInCurrentBlock);
                    // İlerleme Çubuğunu Güncelle
                    pbStatus.Value = Convert.ToInt32((lngBytesProcessed / lngFileLength) * 100);
                }
                // FileStreams ve CryptoStream'i kapatın.
                csCryptoStream.Close();
                giris.Close();
                cikis.Close();

                // Şifreliyorsa orijinal şifrelenmemiş dosyayı silin.
                if (Direction == Sifreleme.sifrele)
                {
                    FileInfo fileOriginal = new FileInfo(gsdosyayolu);
                    fileOriginal.Delete();
                }

                // Şifresini çözüyorsanız şifrelenmiş dosyayı silin.
                if (Direction == Sifreleme.coz)
                {
                    FileInfo fileEncrypted = new FileInfo(gscdosyayolu);
                    fileEncrypted.Delete();
                }

                // Dosya bittiğinde kullanıcıyı güncelleyin
                string Wrap = ((char)(13)).ToString() + ((char)(10)).ToString();
                if (Direction == Sifreleme.sifrele)
                {
                    MessageBox.Show("İşlenmiş toplam bayt = " + lngBytesProcessed.ToString(), "Dosya Şifreleme Tamamlandı." + Wrap + Wrap, MessageBoxButtons.OK,MessageBoxIcon.Information);

                    //İlerleme çubuğunu ve metin kutularını güncelleme.
                    pbStatus.Value = 0;
                    txtFileToEncrypt.Text = "şifrelenecek dosyayı seçiniz";
                    txtPassEncrypt.Text = "";
                    txtConPassEncrypt.Text = "";
                    txtDestinationEncrypt.Text = "";
                    btnChangeEncrypt.Enabled = false;
                    btnEncrypt.Enabled = false;

                }
                else
                {
                    // Dosya bittiğinde kullanıcıyı güncelleyin.
                    MessageBox.Show("İşlenmiş toplam bayt = " + lngBytesProcessed.ToString(), "Şifre Çözme Tamamlandı " + Wrap + Wrap, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                    //İlerleme çubuğunu ve metin kutularını güncelleme.
                   pbStatus.Value = 0;
                   txtFileToDecrypt.Text = "Dosyayı yüklemek için Gözat'ı tıklayın..";
                   txtPassDecrypt.Text = "";
                   txtConPassDecrypt.Text = "";
                   txtDestinationDecrypt.Text = "";
                   btnChangeDecrypt.Enabled = false;
                   btnDecrypt.Enabled = false;
                }


                //seçilen dosyada hata bulunmazsa.
                //if çalışmazsa
            }

            catch (Exception hata)
            {
                giris.Close();
                cikis.Close();

                if (Direction == Sifreleme.sifrele)
                {
                    FileInfo fileDelete = new FileInfo(txtDestinationDecrypt.Text);
                    fileDelete.Delete();
                   pbStatus.Value = 0;
                    txtPassDecrypt.Text = "";
                    txtConPassDecrypt.Text = "";

                    MessageBox.Show("Lütfen şifreyi doğru girdiğinizden emin olmak için kontrol edin", "geçersiz şifre", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    FileInfo fileDelete = new FileInfo(txtDestinationDecrypt.Text);
                    fileDelete.Delete();

                    pbStatus.Value = 0;
                    txtPassEncrypt.Text = "";
                    txtConPassEncrypt.Text = "";

                    MessageBox.Show("bu dosya şifrelenemedi.", "dosya yüklenmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch

            {
                MessageBox.Show("Lütfen " + " yolunun ve dosya adının doğru olup olmadığını ve dosya varsa kontrol edin. ", " Geçersiz Yol veya Dosya Adı",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Diğer tüm hataları yakalayın. Ve kısmi dosyaları sil.
            }



        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtConPassEncrypt.Text.Trim() == "" && txtPassEncrypt.Text.Trim() == "")
            {
                MessageBox.Show("lütfen şifrenizi giriniz");
                return;
            }
            if (txtConPassEncrypt.Text == txtPassEncrypt.Text)
            {
                //Anahtar için değişkenleri bildirin ve iv.
                //Anahtarın 256 bit ve iv 128 bit tutması gerekir.
                byte[] anahtar = null;
                byte[] anahtar2=null;
                //Parolayı anahtar yarata gönderin..
                anahtar = anahtaryarat(txtPassEncrypt.Text);
                // Parolayı CreateIV işlevine gönderin.
                anahtar2 =anahtar2yarat(txtPassEncrypt.Text);
                //şifreleme başladı
               dosyasifreleyadacoz(gsdosyayolu, txtDestinationEncrypt.Text, anahtar, anahtar2, Sifreleme.sifrele);
            }
           
            else
            {
                MessageBox.Show("lütfen şifrenizi tekrar girin.");
                txtPassEncrypt.Text = "";
                txtConPassEncrypt.Text = "";
            }
        }
     private void btnBrowseEncrypt_Click(object sender, EventArgs e)
        {
            //Setup the open dialog.
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "şifrelenecek dosyayı seçiniz";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Tüm dosyalar (*.*) | *.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gsdosyayolu = openFileDialog1.FileName;
                txtFileToEncrypt.Text = gsdosyayolu;

                int iPosition = 0;
                int i = 0;


                while (gsdosyayolu.IndexOf('\\', i) != -1)
                {
                    iPosition = gsdosyayolu.IndexOf('\\', i);
                    i = iPosition + 1;
                }


                gscdosyayolu = gsdosyayolu.Substring(iPosition + 1);

                string S = gsdosyayolu.Substring(0, iPosition + 1);

                gscdosyayolu = gscdosyayolu.Replace('.', '_');

                txtDestinationEncrypt.Text = S + gscdosyayolu + ".encrypt";

                btnEncrypt.Enabled = true;
                btnChangeEncrypt.Enabled = true;

            }

        }

        private void btnBrowseDecrypt_Click(object sender, EventArgs e)
        {
            //open dialogu aç
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Şifresini çözmek için bir dosya seçin";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Şifreli Dosyalar(*.encrypt) | *.encrypt";

            //Kullanıcının bir dosya seçip seçmediğini öğrenin.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               gscdosyayolu = openFileDialog1.FileName;
                txtFileToDecrypt.Text =gscdosyayolu ;
                int iPosition = 0;
                int i = 0;
                // OpenFileDialog.FileName yolundaki son "\" konumunu alın.
                // - 1 aradığınız karakter orada olmadığında.
                // IndexOf soldan sağa arar.

                while (gscdosyayolu.IndexOf('\\', i) != -1)
                {
                    iPosition = gscdosyayolu.IndexOf('\\', i);
                    i = iPosition + 1;
                }

                //sscdosyayolu =  Dosya yolu eksi son 8 karakter(.encrypt)
               sscdosyayolu = gscdosyayolu.Substring(0,gscdosyayolu.Length - 8);
                // Sonuna "\" biten S'ye tüm yolu atayın.
                string S =sscdosyayolu.Substring(0, iPosition + 1);
                // sscdosyayolu öğesini yolun sonundaki "\" konumundan sonraki konumuna atayın.
                sscdosyayolu = sscdosyayolu.Substring((iPosition + 1));
                //noktayı altçizgi ile değiştirmek
                txtDestinationDecrypt.Text = S +sscdosyayolu.Replace('_', '.');
                //butonları değiştir
                btnDecrypt.Enabled = true;
                btnChangeDecrypt.Enabled = true;

            }
        }
        private void btnChangeDecrypt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Şifresi çözülmüş dosyayı yerleştirmek için bir klasör seçin.";
            // Kullanıcı bir klasör seçtiyse yolu txtDestinationDecrypt olarak atayın.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDestinationDecrypt.Text = folderBrowserDialog1.SelectedPath + "\\" +sscdosyayolu.Replace('_', '.');
            }
        }

        private void btnChangeEncrypt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Şifresi çözülmüş dosyayı yerleştirmek için bir klasör seçin.";
            //If the user selected a folder assign the path to txtDestinationEncrypt.
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDestinationEncrypt.Text = folderBrowserDialog1.SelectedPath + "\\" + ssdosyayolu + ".encrypt";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtConPassDecrypt.Text.Trim() == "" || txtPassDecrypt.Text.Trim() == "")
            {
                MessageBox.Show("lütfen şifrenizi giriniz");
                return;
            }
            if (txtConPassDecrypt.Text == txtPassDecrypt.Text)
            {

                // Anahtar için değişkenleri bildirin ve iv.
                // Anahtarın 256 bit ve iv 128 bit tutması gerekir.
                byte[] anahtar = null;
                byte[] anahtar2 = null;

                // Parolayı anahtar yarat işlevine gönderin ..
                anahtar = anahtaryarat(txtPassDecrypt.Text);
                // Parolayı anahtar2yarat işlevine gönderin ..
                anahtar2 = anahtar2yarat(txtPassDecrypt.Text);
                //dosya çözmeye başla
                dosyasifreleyadacoz(txtFileToDecrypt.Text, txtDestinationDecrypt.Text, anahtar, anahtar2, Sifreleme.coz);
            }
           
            else
            {
                MessageBox.Show("lütfen sifrenizi tekrar giriniz.");
                txtPassDecrypt.Text = "";
                txtConPassDecrypt.Text = "";
            }

        }
       private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFileToDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
   
}
