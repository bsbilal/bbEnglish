namespace bbEnglish
{
    partial class frmAdminLogin
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.mtrButtonBackToMain = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(148, 173);
            this.txtPass.MaxLength = 6;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(96, 34);
            this.txtPass.TabIndex = 2;
            // 
            // mtrButtonBackToMain
            // 
            this.mtrButtonBackToMain.Location = new System.Drawing.Point(11, 19);
            this.mtrButtonBackToMain.Name = "mtrButtonBackToMain";
            this.mtrButtonBackToMain.Size = new System.Drawing.Size(140, 24);
            this.mtrButtonBackToMain.TabIndex = 5;
            this.mtrButtonBackToMain.Text = "Ana Ekrana Dönüş";
            this.mtrButtonBackToMain.UseSelectable = true;
            this.mtrButtonBackToMain.Click += new System.EventHandler(this.mtrButtonBackToMain_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(123, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Yönetici şifrenizi girin";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(127, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 47);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 309);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtrButtonBackToMain);
            this.Controls.Add(this.txtPass);
            this.Name = "frmAdminLogin";
            this.Load += new System.EventHandler(this.frmAdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPass;
        private MetroFramework.Controls.MetroButton mtrButtonBackToMain;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}