namespace bbEnglish
{
    partial class FormKelimeSilmeGuncelleme
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
            this.toggleSilGuncelle = new MetroFramework.Controls.MetroToggle();
            this.cmbCategories = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ListKelimeler = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnEditWord = new MetroFramework.Controls.MetroButton();
            this.txtExmSentence = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewDataPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEditCategories = new System.Windows.Forms.ComboBox();
            this.txtNewToTurkish = new System.Windows.Forms.TextBox();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.grpKelime = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.grpKelime.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggleSilGuncelle
            // 
            this.toggleSilGuncelle.AutoSize = true;
            this.toggleSilGuncelle.Location = new System.Drawing.Point(541, 63);
            this.toggleSilGuncelle.Name = "toggleSilGuncelle";
            this.toggleSilGuncelle.Size = new System.Drawing.Size(80, 21);
            this.toggleSilGuncelle.TabIndex = 0;
            this.toggleSilGuncelle.Text = "Off";
            this.toggleSilGuncelle.UseSelectable = true;
            this.toggleSilGuncelle.CheckedChanged += new System.EventHandler(this.toggleSilGuncelle_CheckedChanged);
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.ItemHeight = 24;
            this.cmbCategories.Location = new System.Drawing.Point(137, 101);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(96, 30);
            this.cmbCategories.TabIndex = 2;
            this.cmbCategories.UseSelectable = true;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Kategori";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Kelime Seçin";
            // 
            // ListKelimeler
            // 
            this.ListKelimeler.FormattingEnabled = true;
            this.ListKelimeler.ItemHeight = 16;
            this.ListKelimeler.Location = new System.Drawing.Point(34, 182);
            this.ListKelimeler.Name = "ListKelimeler";
            this.ListKelimeler.Size = new System.Drawing.Size(229, 244);
            this.ListKelimeler.TabIndex = 5;
            this.ListKelimeler.SelectedIndexChanged += new System.EventHandler(this.ListKelimeler_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.LightSalmon;
            this.metroLabel3.Location = new System.Drawing.Point(267, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Örnek Cümle";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(150, 204);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(248, 17);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "örn: (http://www.resimlerim.com/gunes.jpg)";
            // 
            // btnEditWord
            // 
            this.btnEditWord.Location = new System.Drawing.Point(348, 386);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(493, 36);
            this.btnEditWord.TabIndex = 36;
            this.btnEditWord.Text = "Kelimeyi Ekle";
            this.btnEditWord.UseSelectable = true;
            this.btnEditWord.Click += new System.EventHandler(this.btnEditWord_Click);
            // 
            // txtExmSentence
            // 
            this.txtExmSentence.Location = new System.Drawing.Point(267, 33);
            this.txtExmSentence.MaxLength = 245;
            this.txtExmSentence.Name = "txtExmSentence";
            this.txtExmSentence.Size = new System.Drawing.Size(220, 130);
            this.txtExmSentence.TabIndex = 35;
            this.txtExmSentence.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(4, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Fotoğraf bağlantısı";
            // 
            // txtNewDataPath
            // 
            this.txtNewDataPath.Location = new System.Drawing.Point(150, 179);
            this.txtNewDataPath.Name = "txtNewDataPath";
            this.txtNewDataPath.Size = new System.Drawing.Size(337, 22);
            this.txtNewDataPath.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(4, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Kategorisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(4, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Türkçe Karşılığı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kelime";
            // 
            // cmbEditCategories
            // 
            this.cmbEditCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCategories.FormattingEnabled = true;
            this.cmbEditCategories.Location = new System.Drawing.Point(150, 76);
            this.cmbEditCategories.Name = "cmbEditCategories";
            this.cmbEditCategories.Size = new System.Drawing.Size(111, 24);
            this.cmbEditCategories.TabIndex = 29;
            // 
            // txtNewToTurkish
            // 
            this.txtNewToTurkish.Location = new System.Drawing.Point(150, 132);
            this.txtNewToTurkish.Name = "txtNewToTurkish";
            this.txtNewToTurkish.Size = new System.Drawing.Size(111, 22);
            this.txtNewToTurkish.TabIndex = 28;
            // 
            // txtNewWord
            // 
            this.txtNewWord.Location = new System.Drawing.Point(150, 33);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(111, 22);
            this.txtNewWord.TabIndex = 27;
            // 
            // grpKelime
            // 
            this.grpKelime.Controls.Add(this.metroLabel3);
            this.grpKelime.Controls.Add(this.txtNewWord);
            this.grpKelime.Controls.Add(this.metroLabel4);
            this.grpKelime.Controls.Add(this.txtNewToTurkish);
            this.grpKelime.Controls.Add(this.cmbEditCategories);
            this.grpKelime.Controls.Add(this.txtExmSentence);
            this.grpKelime.Controls.Add(this.label5);
            this.grpKelime.Controls.Add(this.label10);
            this.grpKelime.Controls.Add(this.label6);
            this.grpKelime.Controls.Add(this.txtNewDataPath);
            this.grpKelime.Controls.Add(this.label7);
            this.grpKelime.Location = new System.Drawing.Point(341, 142);
            this.grpKelime.Name = "grpKelime";
            this.grpKelime.Size = new System.Drawing.Size(500, 238);
            this.grpKelime.TabIndex = 39;
            this.grpKelime.TabStop = false;
            this.grpKelime.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(525, 106);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(160, 25);
            this.metroLabel5.TabIndex = 40;
            this.metroLabel5.Text = "Güncelleme Modu";
            // 
            // FormKelimeSilmeGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 457);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.grpKelime);
            this.Controls.Add(this.ListKelimeler);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnEditWord);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.toggleSilGuncelle);
            this.Name = "FormKelimeSilmeGuncelleme";
            this.Text = "Kelime Silme/Güncelleme";
            this.Load += new System.EventHandler(this.FormKelimeSilmeGuncelleme_Load);
            this.grpKelime.ResumeLayout(false);
            this.grpKelime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle toggleSilGuncelle;
        private MetroFramework.Controls.MetroComboBox cmbCategories;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListBox ListKelimeler;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnEditWord;
        private System.Windows.Forms.RichTextBox txtExmSentence;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewDataPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEditCategories;
        private System.Windows.Forms.TextBox txtNewToTurkish;
        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.GroupBox grpKelime;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}