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
    public partial class frmKelimeEkleme : MetroFramework.Forms.MetroForm
    {
        string g_word;
        public frmKelimeEkleme()
        {
            InitializeComponent();
        }


        private void frmAdmin_Load(object sender, EventArgs e)
        {
            bindAdmin db = new bindAdmin();
            List<string> cats = new List<string>();
            cats = db.bindUsers();

            foreach (string item in cats)
            {
                cmbCategories.Items.Add(item);
            }




        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            newWord nW = new newWord();
            nW.Kelime = txtNewWord.Text;
            nW.Turkcesi = txtNewToTurkish.Text;
            nW.exSent = txtExmSentence.Text;
            nW.dataPath = txtNewDataPath.Text;
            nW.catID = cmbCategories.SelectedIndex + 1;


            addWord aW = new addWord(nW);

            aW.addToDb();
            g_word = txtNewWord.Text;
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
