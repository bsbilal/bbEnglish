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
    public partial class frmAdminLogin : MetroFramework.Forms.MetroForm
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
           



        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void mtrButtonBackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmNew = new frmLogin();
            frmNew.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Password = txtPass.Text;
            dbConnectClass db = new dbConnectClass();
            bool deger = db.adminLogin(Password);
            if (deger)
            {
                this.Hide();
                FormAdminMain frmNew = new FormAdminMain();
                frmNew.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Hatali sifre girildi..");
        }
    }
}
