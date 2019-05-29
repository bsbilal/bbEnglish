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
namespace bbEnglish
{
    public partial class frmReminderQuests : MetroFramework.Forms.MetroForm
    {
        //soruların ve progress idlerin tutuldugu
        int[,] g_Sorular;
        private List<getQuestList> SoruListesi = new List<getQuestList>();
        //gelen soru sayısı
        private int SoruCount;

        private int SoruValue;

        private int userID;
        int g_imageTrueNumber;
        string g_TextTrueAnswer;
        //birincisi kelime Id'sini progress id
        int y = 0;

        MySQLQuerryExecuter MyS = new MySQLQuerryExecuter();

        int g_imageWordID;
        getImageQuests gImageQuests;
        public frmReminderQuests(int kullaniciID, int SoruSayisi, List<getQuestList> QuestList)
        {
            ///CONSTRUCTOR<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            this.userID = kullaniciID;
            this.SoruListesi = QuestList;
            this.SoruCount = SoruSayisi;
            this.g_Sorular = new int[SoruSayisi, 2];


            InitializeComponent();
        }


        private void frmReminderQuests_Load(object sender, EventArgs e)
        {
            SoruValue=0;
            grpTextQuest.Visible = false;
            //LOAD <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            BindEmptyPictures();

            prgBarSoru.Maximum = SoruCount * 2;
            MessageBox.Show("Yeni kelime öğrenmeden önce çözmeniz gereken " + SoruCount.ToString() + " adet soru var onları cözdükten sonra kelime öğrenmeye devam edebilirsin..");


            g_Sorular = new int[SoruCount, 2];
            int i = 0;
            foreach (var item in SoruListesi)
            {

                //0'da wordid 1'de progress  id
                g_Sorular[i, 0] = item.m_wordID;
                g_Sorular[i++, 1] = item.m_progressID;


            }
            //her soru gecisinde bir artacak




            g_imageWordID = g_Sorular[y, 0];
            getImageQuests gImg = new getImageQuests(g_imageWordID);
            gImageQuests = gImg;
            ResimSorulariBindlama();

            lblSoruIlerlemesi.Text = (SoruValue+1).ToString()+"/"+(SoruCount * 2).ToString();
        }
        void SetProgressBarValue(int setValue)
        {
            prgBarSoru.Value = setValue;
        }

        private void grpImageQuests_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ClearRadioBoxes();
            rdbImageThree.Checked = true;
            SetDefaultPbBackGroundColor();

            grpImageAnswerThree.BackColor = Color.Green;


        }

        private void pBAnswerOne_Click(object sender, EventArgs e)
        {
            ClearRadioBoxes();
            rdbImageOne.Checked = true;
            SetDefaultPbBackGroundColor();
            grpImageAnswerOne.BackColor = Color.Green;

        }

        private void pBAnswerTwo_Click(object sender, EventArgs e)
        {
            ClearRadioBoxes();
            rdbImageTwo.Checked = true;
            SetDefaultPbBackGroundColor();
            grpImageAnswerTwo.BackColor = Color.Green;

        }

        private void pbAnswerFour_Click(object sender, EventArgs e)
        {
            ClearRadioBoxes();
            rdbImageFour.Checked = true;
            SetDefaultPbBackGroundColor();
            grpImageAnswerFour.BackColor = Color.Green;

        }

        void SetDefaultPbBackGroundColor()
        {
            grpImageAnswerOne.BackColor = Color.White;
            grpImageAnswerTwo.BackColor = Color.White;

            grpImageAnswerFour.BackColor = Color.White;
            grpImageAnswerThree.BackColor = Color.White;

        }

        private void btnNextQuest_Click(object sender, EventArgs e)
        {

            //sorunun kontrol edildigi bölüm
            CheckImageTrueFalse();
            
            
            //önceki sorudan kalan yeşilligi temizledik
            SetWhiteTextGroupBoxesColor();

            //Cevapların eklendigi bölüm
            string[] textAnswers = new string[4];

            getTextAnswers gTextQuests = new getTextAnswers();


            ///burayagüncelleme yapacagız g sorular ikinci indis degerini kullanmadan cekecegiz sadece kelime
            textAnswers = gTextQuests.GetQuestbyProgressID(g_Sorular[y, 0], g_Sorular[y, 1] + 1);
            g_TextTrueAnswer = gTextQuests.getTrueAnswer();
            bindAnswers(textAnswers);
            //rastgele dagıtmak icin fonksiyonumuzu calistirdik 


            grpImageQuests.Visible = false; ;
            grpTextQuest.Visible = true;
            SetProgressBarValue(++SoruValue);
            lblSoruIlerlemesi.Text = (SoruValue + 1).ToString() + "/" + (SoruCount * 2).ToString();

        }
        //sorunun cevaplarını rastgele dagıtıyor 
        void bindAnswers(string[] ArrAnswers)
        {
            int[] sayilar = new int[4];
            sayilar[0] = 7;
            sayilar[1] = 7;
            sayilar[2] = 7;
            sayilar[3] = 7;

            Random rastgele = new Random();
            int i = 0;
            while (i < 4)
            {
                int sayi = rastgele.Next(4);
                if (sayilar.Contains(sayi))
                    continue;
                sayilar[i] = sayi;
                i++;
            }
            txtTextAnswerOne.Text = ArrAnswers[sayilar[0]];
            txtTextAnswerTwo.Text = ArrAnswers[sayilar[3]];
            txtTextAnswerThree.Text = ArrAnswers[sayilar[2]];
            txtTextAnswerFour.Text = ArrAnswers[sayilar[1]];

        }

        //resimin doğru mu yanlış mı olduguna bakıyor
        void CheckImageTrueFalse()
        {
            if (g_imageTrueNumber == 0 && rdbImageOne.Checked)
                MessageBox.Show("Cevabınız Dogru");
            else if (g_imageTrueNumber == 1 && rdbImageTwo.Checked)
                MessageBox.Show("Cevabınız Dogru");

            else if (g_imageTrueNumber == 2 && rdbImageThree.Checked)
                MessageBox.Show("Cevabınız Dogru");

            else if (g_imageTrueNumber == 3 && rdbImageFour.Checked)
                MessageBox.Show("Cevabınız Dogru");

            else
                MessageBox.Show("Cevabınız yanlış");
        }

        //imageboxların içindeki radiobutonları boşaltıyor
        void ClearRadioBoxes()
        {
            rdbImageOne.Checked = false;
            rdbImageTwo.Checked = false;
            rdbImageThree.Checked = false;
            rdbImageFour.Checked = false;
        }
        // LOREM PIC BINDING <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        void BindEmptyPictures()
        {
            pBAnswerOne.SizeMode = PictureBoxSizeMode.StretchImage;
            pBAnswerTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnswerThree.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnswerFour.SizeMode = PictureBoxSizeMode.StretchImage;
            string lorem = "http://lorempixel.com/200/200/";
            try {
                pBAnswerOne.ImageLocation = lorem;
                pBAnswerTwo.ImageLocation = lorem;
                pbAnswerThree.ImageLocation = lorem;
                pbAnswerFour.ImageLocation = lorem;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
        void ResimSorulariBindlama()
        {
          




            newWord nW = new newWord();
            learnNewWord lW = new learnNewWord(userID);
            nW = lW.GetFromDb(g_Sorular[y, 0]);
            txtImageQuest.Text = "Hangisi '" + nW.Kelime + "'  ?";
            txtQuest.Text = "'" + nW.Kelime + "' Türkçe karşılığını seçin..";

            string ResimDogruCevap = gImageQuests.DogruCevap();

            Random rastgele = new Random();
            int sayi = rastgele.Next(4);
            //rastgele sayı üretip fotoğrafı  bindledik

            g_imageTrueNumber = sayi;

            if (sayi == 0)
            {
                try
                {
                    var request = WebRequest.Create(ResimDogruCevap);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pBAnswerOne.ImageLocation = ResimDogruCevap;
                        pBAnswerOne.Image = Bitmap.FromStream(stream);

                    }

                }
                catch
                {
                    pBAnswerOne.Image = Image.FromFile("C:\\notFound.png");
                }
            }
            else if (sayi == 1)
            {
                try
                {
                    var request = WebRequest.Create(ResimDogruCevap);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pBAnswerTwo.Image = Bitmap.FromStream(stream);
                        pBAnswerTwo.ImageLocation = ResimDogruCevap;


                    }

                }
                catch
                {
                    pBAnswerTwo.Image = Image.FromFile("C:\\notFound.png");
                }
            }
            else if (sayi == 2)

            {
                try
                {
                    var request = WebRequest.Create(ResimDogruCevap);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pbAnswerThree.ImageLocation = ResimDogruCevap;

                        pbAnswerThree.Image = Bitmap.FromStream(stream);

                    }

                }
                catch
                {
                    pbAnswerThree.Image = Image.FromFile("C:\\notFound.png");
                }
            }
            else if (sayi == 3)

            {
                try
                {
                    var request = WebRequest.Create(ResimDogruCevap);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pbAnswerFour.ImageLocation = ResimDogruCevap;
                        pbAnswerFour.Image = Bitmap.FromStream(stream);

                    }

                }
                catch
                {
                    pbAnswerFour.Image = Image.FromFile("C:\\notFound.png");
                }
            }
            else
                MessageBox.Show("Hata oluştu..!");

        }


        private void rdbImageThree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNextImageQuest_Click(object sender, EventArgs e)
        {
            if(TextQuestIsCorrect())
            {
                string Sorgu;
                    //1.Sİ userID, 2.si wordid 3. progressid +1
                  Sorgu  = "CALL UPDATE_LEARN_STATUS("+userID+","+g_Sorular[y,0]+","+ (g_Sorular[y, 1]+1)+ ")";
                //öğrenildiyse direkt 6ya atıyoruz
                if (g_Sorular[y, 1]+1==5)
                  Sorgu = "CALL UPDATE_LEARN_STATUS(" + userID + "," + g_Sorular[y, 0] + "," + (g_Sorular[y, 1] + 2) + ")";

                MyS.execute(Sorgu);

            }
            else
            {


            }

            
            //y soru dizisinde gezmemizi saglıyor
            y++;
            if (y == SoruCount)
            { 
                this.Close();
            }
            else { 
            g_imageWordID = g_Sorular[y, 0];
            getImageQuests gImg = new getImageQuests(g_imageWordID);
            gImageQuests = gImg;
                pBAnswerOne.Image = null;
                pBAnswerTwo.Image = null;
                pbAnswerThree.Image = null;
                pbAnswerFour.Image = null;
                SetDefaultPbBackGroundColor();
                BindEmptyPictures();
            ResimSorulariBindlama();
            ClearRadioBoxes();
            }
            grpImageQuests.Visible = true;
            grpTextQuest.Visible = false;
            SetProgressBarValue(++SoruValue);
            lblSoruIlerlemesi.Text = (SoruValue + 1).ToString() + "/" + (SoruCount * 2).ToString();


        }
        bool TextQuestIsCorrect()
        {
            bool isTrue=false;   
            if (grpTextAnswerOne.BackColor == Color.Green && g_TextTrueAnswer == txtTextAnswerOne.Text)
            {
                MessageBox.Show("Cevabınız Doğru ");
                isTrue = true;

            }
            else if (grpTextAnswerTwo.BackColor == Color.Green && g_TextTrueAnswer == txtTextAnswerTwo.Text)
            {
                MessageBox.Show("Cevabınız Doğru ");
                isTrue = true;
            }
            else if (grpTextAnswerThree.BackColor == Color.Green && g_TextTrueAnswer == txtTextAnswerThree.Text)
            {
                MessageBox.Show("Cevabınız Doğru ");
                isTrue = true;
            }
            else if (grpTextAnswerFour.BackColor == Color.Green && g_TextTrueAnswer == txtTextAnswerFour.Text)
            {
                MessageBox.Show("Cevabınız Doğru ");
                isTrue = true;
            }
            else
            {

                MessageBox.Show("Cevabınız yanlıs sonra tekrar deneyin");

            }
            return isTrue;

        }
       
        void SetWhiteTextGroupBoxesColor()
        {
            grpTextAnswerOne.BackColor = Color.White;
            grpTextAnswerTwo.BackColor = Color.White;
            grpTextAnswerThree.BackColor = Color.White;
            grpTextAnswerFour.BackColor = Color.White;
        }

    

        private void txtTextAnswerOne_Click(object sender, EventArgs e)
        {
            SetWhiteTextGroupBoxesColor();
            grpTextAnswerOne.BackColor = Color.Green;
            grpTextAnswerTwo.BackColor = Color.White;
            grpTextAnswerThree.BackColor = Color.White;
            grpTextAnswerFour.BackColor = Color.White;
        }

        private void txtTextAnswerTwo_Click(object sender, EventArgs e)
        {
            SetWhiteTextGroupBoxesColor();
            grpTextAnswerOne.BackColor = Color.White;
            grpTextAnswerTwo.BackColor = Color.Green;
            grpTextAnswerThree.BackColor = Color.White;
            grpTextAnswerFour.BackColor = Color.White;
        }

        private void txtTextAnswerThree_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void txtTextAnswerThree_Click(object sender, EventArgs e)
        {
            SetWhiteTextGroupBoxesColor();
            grpTextAnswerOne.BackColor = Color.White;
            grpTextAnswerTwo.BackColor = Color.White;
            grpTextAnswerThree.BackColor = Color.Green;
            grpTextAnswerFour.BackColor = Color.White;
        }

        private void txtTextAnswerFour_Click(object sender, EventArgs e)
        {
            SetWhiteTextGroupBoxesColor();
            grpTextAnswerOne.BackColor = Color.White;
            grpTextAnswerTwo.BackColor = Color.White;
            grpTextAnswerThree.BackColor = Color.White;
            grpTextAnswerFour.BackColor = Color.Green;
        }

        private void grpTextQuest_Enter(object sender, EventArgs e)
        {

        }

        private void prgBarSoru_Click(object sender, EventArgs e)
        {

        }
    }

}
