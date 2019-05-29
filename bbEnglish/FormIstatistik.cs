using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbEnglish
{
    public partial class FormIstatistik : MetroFramework.Forms.MetroForm
    {
        int g_UserId;
        int g_yil;
        string g_UyeAdi;
        public FormIstatistik()
        {
            InitializeComponent();
        }
        
        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            bindUsers();

           
            cmbYillar.Items.Add("2018");
            cmbYillar.Items.Add("2019");

        }

        private void grafikOgrenilenKelime_Click(object sender, EventArgs e)
        {

        }
        void bindUsers()
        {
            loginBind db = new loginBind();
            List<string> users = new List<string>();
            users = db.bindUsers();

            foreach (string item in users)
            {
                if (item == "Admin")
                    continue;
                cmbUyeler.Items.Add(item);
            }

        }
        void DrawPieGraph()
        {
            //0. kişinin ogrendigi kelime sayısı 1. toplam kelime sayısı
            int[] Veriler = new int[2];
            GetStats gs = new GetStats();

            Veriler= gs.GetWordCounts(g_UserId);



            foreach (var series in grafikPastaTum.Series)
            {
                series.Points.Clear();
            }

            //verileri ekliyoruz
            grafikPastaTum.Series["Kelimeler"].Points.Add(Veriler[0]);
            grafikPastaTum.Series["Kelimeler"].Points.Add(Veriler[1]);
     

            grafikPastaTum.Series["Kelimeler"].Points[0].AxisLabel = "Öğrenilen Kelimeler";
            grafikPastaTum.Series["Kelimeler"].Points[1].AxisLabel = "Öğrenilmemiş Kelimeler";
            
            grafikPastaTum.Series["Kelimeler"].Points[0].Color = Color.Aqua;
            grafikPastaTum.Series["Kelimeler"].Points[1].Color = Color.Chocolate;
     
            grafikPastaTum.ChartAreas[0].AxisX.LabelStyle.Angle = -70;
            grafikPastaTum.BackColor = Color.White;//Arka Plan rengi

            lblToplam.Text = g_UyeAdi + " isimli üye " + Veriler[1] + " kelimenin " + Veriler[0] + " tanesini öğrendi.!";
        }

        private void cmbUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {

            g_UyeAdi = cmbUyeler.GetItemText(cmbUyeler.SelectedItem);
            getUserID GU_ID =new getUserID();


            g_UserId = GU_ID.Data(g_UyeAdi);

        foreach (var series in grafikOgrenilenKelime.Series)
            {
                series.Points.Clear();
            }

            DrawPieGraph();
            
        }
        void DrawBarGraphics()
        {
            foreach (var series in grafikOgrenilenKelime.Series)
            {
                series.Points.Clear();
            }

            int[] Veriler = new int[12];
            GetStats gs = new GetStats();

            if (g_yil == 2018)
               Veriler= gs.Get2018(g_UserId);
            if(g_yil==2019)
               Veriler= gs.Get2019(g_UserId);


            for (int i = 0; i < 12; i++)
            {
                if (g_yil == 2019 && i == 5)
                    break;
                grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points.Add(Veriler[i]);
               
            }
          
      

          
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[0].AxisLabel = "Ocak";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[1].AxisLabel = "Şubat";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[2].AxisLabel = "Mart";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[3].AxisLabel = "Nisan";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[4].AxisLabel = "Mayıs";

            if (g_yil == 2018) { 
                grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[5].AxisLabel = "Haziran";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[6].AxisLabel = "Temmuz";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[7].AxisLabel = "Ağustos";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[8].AxisLabel = "Eylül";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[9].AxisLabel = "Ekim";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[10].AxisLabel = "Kasım";
            grafikOgrenilenKelime.Series["Öğrenilen Kelime"].Points[11].AxisLabel = "Aralık";
            }
        }

        private void cmbYillar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cmbYillar.SelectedIndex==0)
                g_yil = 2018;

            
            else if(cmbYillar.SelectedIndex==1)
                g_yil = 2019;

            DrawBarGraphics();


        }
    }
}
