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

    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // soruları kouşullara gore guncelledik
            MySQLQuerryExecuter mys = new MySQLQuerryExecuter();
            string sorgu= "CALL CALC_QUESTABLE_QUESTIONS()";
            mys.execute(sorgu);




            btnUserLogin.Visible = false;
            btnNewUser.Visible = false;
            lblKontrol.Visible = false;
            loginBind db = new loginBind();
            List<string> users = new List<string>();
            users = db.bindUsers();

            foreach (string item in users)
            {
                if (item == "Admin")
                    continue;
                cmbUsers.Items.Add(item);
            }


        }

        private void txtNewUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        //ilk acilistaki gizlemeler
        void txtChangedFirstVisibles()
        {
           

            // sadece combobox secildigi zaman görünür oluyor
            btnUserLogin.Visible = false;
            if (txtNewUser.Text.Length == 0)
            {
               
                lblKontrol.Visible = false;
                lblKontrol.Text = "";
                cmbUsers.Visible = true;
                btnNewUser.Visible = false;
                
            }
            else
            {
                btnNewUser.Visible = true;
                cmbUsers.Visible = false;
            }
            btnNewUser.Text = txtNewUser.Text + " adıyla yeni hesap olustur";

        }
        void isAvailable()
        {
            lblKontrol.Visible = true;
            lblKontrol.ForeColor = Color.Green;
            lblKontrol.Text = "Bu kullanıcı adı uygun!";
            btnNewUser.Enabled = true;

        }

        void isntAvailable()
        {
            lblKontrol.Visible = true;
            lblKontrol.ForeColor = Color.Red;
            lblKontrol.Text = "Bu kullanıcı adı kullanımda..";
            btnNewUser.Text = "Uygun Değil";
            btnNewUser.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsShowAdmin_Click(object sender, EventArgs e)
        {



            this.Hide();
            frmAdminLogin frmNew = new frmAdminLogin();
            frmNew.ShowDialog();
            this.Close();



        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
        
        }

        private void btnUserLogin_Click_1(object sender, EventArgs e)
        {
            getUserID getID = new getUserID();

            this.Hide();
            frmUser frmNew = new frmUser(getID.Data(cmbUsers.SelectedItem.ToString()), cmbUsers.SelectedItem.ToString());
            frmNew.ShowDialog();
            this.Close();
        }

        private void cmbUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnUserLogin.Visible = true;
            btnUserLogin.Text = cmbUsers.Text + "  ile giriş yap";
        }

        private void txtNewUser_TextChanged_1(object sender, EventArgs e)
        {
            btnUserLogin.Visible = false;

            //kullanılabilir olup olmadıgını kontrol ediyor
            bool isUsability = false;
            //txt changed visibles'ı sayesinde ilk açılışta hepsinin degerleri belirlendi
            txtChangedFirstVisibles();

            string cmbUsernames = "";
            int c = 0;
            while (c < cmbUsers.Items.Count)
            {
                cmbUsers.SelectedIndex = c;
                cmbUsernames = cmbUsers.SelectedItem.ToString();
                if (txtNewUser.Text.ToLower() == "admin")
                    isUsability = false;

                else if (txtNewUser.Text == cmbUsernames)
                {
                    isUsability = false;
                }
                else
                {
                    isUsability = true;

                }
                c++;
            }

            if (isUsability)
            {
                isAvailable();
                if (txtNewUser.Text.Length == 0)
                    lblKontrol.Visible = false;

            }
            else
            {

                isntAvailable();
            }

            btnUserLogin.Visible = false;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            MySQLQuerryExecuter MyS = new MySQLQuerryExecuter();
            string MySQuerry = "CALL ADD_NEW_USER('" + txtNewUser.Text + "')";
            MyS.execute(MySQuerry);

            getUserID getID = new getUserID();

            this.Hide();
            frmUser frmNew = new frmUser(getID.Data(txtNewUser.Text), txtNewUser.Text);
            frmNew.ShowDialog();
            this.Close();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void xxx_Click(object sender, EventArgs e)
        {

        }
    }
}