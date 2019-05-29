using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
namespace bbEnglish
{
    public partial class FormKelimeSilmeGuncelleme : MetroFramework.Forms.MetroForm
    {
        BindEditWords bindWords = new BindEditWords();

        List<newWord> Kelimeler = new List<newWord>();
        string SecilenKelime;

        public FormKelimeSilmeGuncelleme()
        {
            InitializeComponent();
        }

        private void FormKelimeSilmeGuncelleme_Load(object sender, EventArgs e)
        {
            bindAdmin db = new bindAdmin();
            List<string> cats = new List<string>();
            cats = db.bindUsers();

            foreach (string item in cats)
            {
                cmbCategories.Items.Add(item);
                cmbEditCategories.Items.Add(item);
            }

        }

        private void toggleSilGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            if(toggleSilGuncelle.Checked==true)
            {
                metroLabel5.Text = "Silme Modu";
                metroLabel5.ForeColor = Color.Red;
                grpKelime.Enabled = false;
                btnEditWord.Text = "Kelimeyi Sil";
            }

            else
            {
                metroLabel5.ForeColor = Color.Brown;
                metroLabel5.Text = "Güncelleme Modu";
                grpKelime.Enabled = true;
                btnEditWord.Text = "Kelimeyi Güncelle";

            }

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //geleni kelimeler sinifina bastik
           Kelimeler=bindWords.getWords(cmbCategories.SelectedIndex + 1);
            
            ListKelimeler.Items.Clear();

            foreach (newWord item in Kelimeler)
            {
                ListKelimeler.Items.Add(item.Kelime);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ListKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenKelime = ListKelimeler.GetItemText(ListKelimeler.SelectedItem);

            this.Height = 357;
            this.Width = 667;


            foreach (var item in Kelimeler)
            {
               if(item.Kelime==SecilenKelime)
                {
                    txtNewWord.Text = item.Kelime;
                    txtNewToTurkish.Text = item.Turkcesi;
                    txtExmSentence.Text = item.exSent;
                    txtNewDataPath.Text = item.dataPath;
                    cmbEditCategories.SelectedIndex = item.catID - 1;
                }

            }

        }

        private void btnEditWord_Click(object sender, EventArgs e)
        {
            MySQLQuerryExecuter MyS = new MySQLQuerryExecuter();
            if (toggleSilGuncelle.Checked == true)
            {
                DialogResult dr = MetroMessageBox.Show(this, "\n\n"+SecilenKelime+" Silinecek onaylıyor musunuz?", "Kelime Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    string querryString = "CALL DELETE_WORD_BY_CATEGORY(" + (cmbCategories.SelectedIndex + 1).ToString() + ",'" + SecilenKelime + "')";
                    MyS.execute(querryString);
                    MetroMessageBox.Show(this,"Silindi..!");
                    this.Height = 337;
                    this.Width = 257;

                }
                else
                {
                    
                }

              
               
            }

            else
            {
                DialogResult dr = MetroMessageBox.Show(this, "\n\n" + SecilenKelime + " Güncellenecek onaylıyor musunuz?", "Kelime Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string querryString = "CALL UPDATE_WORD_BY_CATEGORY('" + txtNewWord.Text + "'," + (cmbEditCategories.SelectedIndex + 1).ToString() + ",'" + txtNewToTurkish.Text + "','" + txtExmSentence.Text + "','" + txtNewDataPath.Text + "'," + (cmbCategories.SelectedIndex + 1).ToString() + ",'" + SecilenKelime + "')";
                    MyS.execute(querryString);
                    MetroMessageBox.Show(this, "Güncelleme Yapıldı..!");
                    this.Height = 357;
                    this.Width = 257;

                }
     
            }
        }
    }
}
