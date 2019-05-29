namespace bbEnglish
{
    partial class FormAdminMain
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
            this.btnEkleme = new MetroFramework.Controls.MetroTile();
            this.btnDuzenleme = new MetroFramework.Controls.MetroTile();
            this.btnIstatistik = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnEkleme
            // 
            this.btnEkleme.ActiveControl = null;
            this.btnEkleme.Location = new System.Drawing.Point(95, 83);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(232, 104);
            this.btnEkleme.TabIndex = 0;
            this.btnEkleme.Text = "Kelime Ekleme";
            this.btnEkleme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkleme.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnEkleme.UseSelectable = true;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // btnDuzenleme
            // 
            this.btnDuzenleme.ActiveControl = null;
            this.btnDuzenleme.Location = new System.Drawing.Point(370, 83);
            this.btnDuzenleme.Name = "btnDuzenleme";
            this.btnDuzenleme.Size = new System.Drawing.Size(232, 104);
            this.btnDuzenleme.TabIndex = 1;
            this.btnDuzenleme.Text = "Kelime Düzenleme/Silme";
            this.btnDuzenleme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDuzenleme.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDuzenleme.UseSelectable = true;
            this.btnDuzenleme.Click += new System.EventHandler(this.btnDuzenleme_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.ActiveControl = null;
            this.btnIstatistik.Location = new System.Drawing.Point(95, 219);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(507, 104);
            this.btnIstatistik.TabIndex = 3;
            this.btnIstatistik.Text = "Istatistik Görüntüleme";
            this.btnIstatistik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIstatistik.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnIstatistik.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnIstatistik.UseSelectable = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // FormAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 398);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnDuzenleme);
            this.Controls.Add(this.btnEkleme);
            this.Name = "FormAdminMain";
            this.Text = "Yönetici Ekranı";
            this.Load += new System.EventHandler(this.FormAdminMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnEkleme;
        private MetroFramework.Controls.MetroTile btnDuzenleme;
        private MetroFramework.Controls.MetroTile btnIstatistik;
    }
}