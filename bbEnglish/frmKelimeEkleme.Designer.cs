namespace bbEnglish
{
    partial class frmKelimeEkleme
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
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.txtNewToTurkish = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewDataPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExmSentence = new System.Windows.Forms.RichTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.btnAddWord = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtNewWord
            // 
            this.txtNewWord.Location = new System.Drawing.Point(170, 85);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(111, 22);
            this.txtNewWord.TabIndex = 0;
            // 
            // txtNewToTurkish
            // 
            this.txtNewToTurkish.Location = new System.Drawing.Point(170, 155);
            this.txtNewToTurkish.Name = "txtNewToTurkish";
            this.txtNewToTurkish.Size = new System.Drawing.Size(111, 22);
            this.txtNewToTurkish.TabIndex = 1;
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(170, 120);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(111, 24);
            this.cmbCategories.TabIndex = 12;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(23, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kelime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(24, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Türkçe Karşılığı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(24, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kategorisi";
            // 
            // txtNewDataPath
            // 
            this.txtNewDataPath.Location = new System.Drawing.Point(170, 187);
            this.txtNewDataPath.Name = "txtNewDataPath";
            this.txtNewDataPath.Size = new System.Drawing.Size(199, 22);
            this.txtNewDataPath.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(24, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fotoğraf bağlantısı";
            // 
            // txtExmSentence
            // 
            this.txtExmSentence.Location = new System.Drawing.Point(287, 102);
            this.txtExmSentence.MaxLength = 245;
            this.txtExmSentence.Name = "txtExmSentence";
            this.txtExmSentence.Size = new System.Drawing.Size(220, 79);
            this.txtExmSentence.TabIndex = 20;
            this.txtExmSentence.Text = "";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(-19, -19);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.metroProgressBar1.TabIndex = 23;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(375, 193);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(132, 36);
            this.btnAddWord.TabIndex = 24;
            this.btnAddWord.Text = "Kelimeyi Ekle";
            this.btnAddWord.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(72, 212);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(248, 17);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "örn: (http://www.resimlerim.com/gunes.jpg)";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.LightSalmon;
            this.metroLabel2.Location = new System.Drawing.Point(287, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Örnek Cümle";
            // 
            // frmKelimeEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 270);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.txtExmSentence);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNewDataPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.txtNewToTurkish);
            this.Controls.Add(this.txtNewWord);
            this.Name = "frmKelimeEkleme";
            this.Text = "Yeni Kelime Ekleme";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.TextBox txtNewToTurkish;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewDataPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtExmSentence;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton btnAddWord;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}