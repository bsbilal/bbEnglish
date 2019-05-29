namespace bbEnglish
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnsShowAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbUsers = new MetroFramework.Controls.MetroComboBox();
            this.btnUserLogin = new MetroFramework.Controls.MetroButton();
            this.txtNewUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnNewUser = new MetroFramework.Controls.MetroButton();
            this.lblKontrol = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsShowAdmin
            // 
            this.btnsShowAdmin.Location = new System.Drawing.Point(477, 377);
            this.btnsShowAdmin.Name = "btnsShowAdmin";
            this.btnsShowAdmin.Size = new System.Drawing.Size(104, 23);
            this.btnsShowAdmin.TabIndex = 3;
            this.btnsShowAdmin.Text = "Admin Girişi";
            this.btnsShowAdmin.UseVisualStyleBackColor = true;
            this.btnsShowAdmin.Click += new System.EventHandler(this.btnsShowAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ya da Yeni hesap olusturabilirsin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesabını seçip kaldığın yerden devam edebilirsin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(582, 157);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(481, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.ItemHeight = 24;
            this.cmbUsers.Location = new System.Drawing.Point(132, 205);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(195, 30);
            this.cmbUsers.TabIndex = 13;
            this.cmbUsers.UseSelectable = true;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged_1);
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Location = new System.Drawing.Point(353, 204);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(159, 36);
            this.btnUserLogin.TabIndex = 14;
            this.btnUserLogin.Text = "Giriş Yap";
            this.btnUserLogin.UseSelectable = true;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click_1);
            // 
            // txtNewUser
            // 
            // 
            // 
            // 
            this.txtNewUser.CustomButton.Image = null;
            this.txtNewUser.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtNewUser.CustomButton.Name = "";
            this.txtNewUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewUser.CustomButton.TabIndex = 1;
            this.txtNewUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewUser.CustomButton.UseSelectable = true;
            this.txtNewUser.CustomButton.Visible = false;
            this.txtNewUser.Lines = new string[0];
            this.txtNewUser.Location = new System.Drawing.Point(243, 267);
            this.txtNewUser.MaxLength = 32767;
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.PasswordChar = '\0';
            this.txtNewUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewUser.SelectedText = "";
            this.txtNewUser.SelectionLength = 0;
            this.txtNewUser.SelectionStart = 0;
            this.txtNewUser.ShortcutsEnabled = true;
            this.txtNewUser.Size = new System.Drawing.Size(209, 23);
            this.txtNewUser.TabIndex = 15;
            this.txtNewUser.UseSelectable = true;
            this.txtNewUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUser.TextChanged += new System.EventHandler(this.txtNewUser_TextChanged_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(132, 269);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 20);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Hesap Adı :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(135, 321);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(329, 49);
            this.btnNewUser.TabIndex = 17;
            this.btnNewUser.UseSelectable = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Location = new System.Drawing.Point(190, 385);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(87, 20);
            this.lblKontrol.TabIndex = 18;
            this.lblKontrol.Text = "metroLabel2";
            this.lblKontrol.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 413);
            this.Controls.Add(this.lblKontrol);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.btnUserLogin);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsShowAdmin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsShowAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroComboBox cmbUsers;
        private MetroFramework.Controls.MetroButton btnUserLogin;
        private MetroFramework.Controls.MetroTextBox txtNewUser;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnNewUser;
        private MetroFramework.Controls.MetroLabel lblKontrol;
    }
}

