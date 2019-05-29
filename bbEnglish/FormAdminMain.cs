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
    public partial class FormAdminMain : MetroFramework.Forms.MetroForm
    {
        public FormAdminMain()
        {
            InitializeComponent();
        }

        private void FormAdminMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKelimeEkleme frmNew = new frmKelimeEkleme();
            frmNew.ShowDialog();
            this.Show(); 
        }

        private void btnDuzenleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelimeSilmeGuncelleme frmNew = new FormKelimeSilmeGuncelleme();
            frmNew.ShowDialog();
            this.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIstatistik frmNew = new FormIstatistik();
            frmNew.ShowDialog();
            this.Show();

        }
    }
}
