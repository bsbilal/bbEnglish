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
    public partial class frmUser : MetroFramework.Forms.MetroForm
    {
        private int UserID;
        public frmUser(int userid,string userName)
        {
            InitializeComponent();
            //hangi kullanıcı oldugunu id'sini laıdk
            UserID = userid;
            this.Text = " hoşgeldin " + userName;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
           
            getRemindQuestcs getRmQ = new getRemindQuestcs(UserID);
            List<getQuestList> SoruListesi = new List<getQuestList>();
            SoruListesi = getRmQ.GetQuest();
            int SoruSayisi = getRmQ.Count();
            if (getRmQ.Count()>=1)
                {
                this.Hide();
                frmReminderQuests frmNew = new frmReminderQuests(UserID,SoruSayisi,SoruListesi);
                frmNew.ShowDialog();
                this.Show();

            }

        }

        private void btnLearnWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLearnWord frmNew = new frmLearnWord(UserID);
            frmNew.ShowDialog();
            this.Show();
        }
    }
}
