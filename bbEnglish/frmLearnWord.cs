using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SpeechLib;
namespace bbEnglish
{
    public partial class frmLearnWord : MetroFramework.Forms.MetroForm
    {
        private int uID;
        public frmLearnWord(int userID)
        {
            this.uID = userID;
            InitializeComponent();
        }

        private void frmLearnWord_Load(object sender, EventArgs e)
        {

            lblWordId.Visible = false;
            //konusma butonlarının ozellikleri ve fotoğrafları yüklendi
            BindSpeechButtons();


            learnNewWord learnNW = new learnNewWord(uID);
            newWord nW;
            nW = learnNW.getWord();
            //ekranların doldurulması
            txtWord.Text = nW.Kelime;
            txtToTurkish.Text = nW.Turkcesi;
            txtExSentence.Text = nW.exSent;
            bindPictureBox(nW.dataPath);
            //kategori id'sine göre kategorinin bildirilmesi
            if (nW.catID == 1)
                txtCat.Text = "Fiil";
            else if (nW.catID == 2)
                txtCat.Text = "Sıfat";
            else if (nW.catID == 3)
                txtCat.Text = "Isim";
            lblWordId.Text = nW.WordID.ToString();
        }

        private void btnLearnPass_Click(object sender, EventArgs e)
        {
            learnNewWord learnNW = new learnNewWord(uID);
            learnNW.AddToDb(Convert.ToInt16(lblWordId.Text));
            this.Close();
        }


        //resim  ekranının basılması
        void bindPictureBox(string path)
        {
            pbWordImage.SizeMode = PictureBoxSizeMode.StretchImage;


            try
            {
                var request = WebRequest.Create(path);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pbWordImage.Image = Bitmap.FromStream(stream);

                }
            }
            catch
            {
                pbWordImage.Image = Image.FromFile("C:\\notFound.png");
            }

        }

        //okutma fonksiyonu
        void Speech(string text)
        {
            SpVoice oku = new SpVoice();
            oku.Speak(text, SpeechVoiceSpeakFlags.SVSFDefault);

        }


        private void pbSpeechWord_Click(object sender, EventArgs e)
        {
            Speech(txtWord.Text);
        }

        private void pbSpeechText_Click(object sender, EventArgs e)
        {
            Speech(txtExSentence.Text);
        }
        void BindSpeechButtons()
        {
            pbSpeechText.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpeechWord.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpeechText.Image = Image.FromFile("C:\\HeadPhone.png");
            pbSpeechWord.Image = Image.FromFile("C:\\HeadPhone.png");
        }
    }
}
