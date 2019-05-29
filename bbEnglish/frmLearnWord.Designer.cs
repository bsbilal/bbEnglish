namespace bbEnglish
{
    partial class frmLearnWord
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
            this.pbWordImage = new System.Windows.Forms.PictureBox();
            this.txtExSentence = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtToTurkish = new System.Windows.Forms.TextBox();
            this.btnLearnPass = new System.Windows.Forms.Button();
            this.pbSpeechText = new System.Windows.Forms.PictureBox();
            this.pbSpeechWord = new System.Windows.Forms.PictureBox();
            this.lblWordId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeechText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeechWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWordImage
            // 
            this.pbWordImage.Location = new System.Drawing.Point(514, 77);
            this.pbWordImage.Name = "pbWordImage";
            this.pbWordImage.Size = new System.Drawing.Size(304, 176);
            this.pbWordImage.TabIndex = 0;
            this.pbWordImage.TabStop = false;
            // 
            // txtExSentence
            // 
            this.txtExSentence.BackColor = System.Drawing.Color.Coral;
            this.txtExSentence.Enabled = false;
            this.txtExSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExSentence.Location = new System.Drawing.Point(62, 259);
            this.txtExSentence.Name = "txtExSentence";
            this.txtExSentence.Size = new System.Drawing.Size(715, 94);
            this.txtExSentence.TabIndex = 1;
            this.txtExSentence.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(56, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türkçe Karşılığı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(56, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorisi";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.SkyBlue;
            this.txtWord.Enabled = false;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(243, 78);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(203, 34);
            this.txtWord.TabIndex = 5;
            // 
            // txtCat
            // 
            this.txtCat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtCat.Enabled = false;
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.Location = new System.Drawing.Point(243, 133);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(203, 34);
            this.txtCat.TabIndex = 6;
            // 
            // txtToTurkish
            // 
            this.txtToTurkish.BackColor = System.Drawing.Color.LightBlue;
            this.txtToTurkish.Enabled = false;
            this.txtToTurkish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToTurkish.Location = new System.Drawing.Point(243, 190);
            this.txtToTurkish.Name = "txtToTurkish";
            this.txtToTurkish.Size = new System.Drawing.Size(203, 34);
            this.txtToTurkish.TabIndex = 7;
            // 
            // btnLearnPass
            // 
            this.btnLearnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearnPass.Location = new System.Drawing.Point(243, 366);
            this.btnLearnPass.Name = "btnLearnPass";
            this.btnLearnPass.Size = new System.Drawing.Size(357, 63);
            this.btnLearnPass.TabIndex = 8;
            this.btnLearnPass.Text = "Öğrendim!";
            this.btnLearnPass.UseVisualStyleBackColor = true;
            this.btnLearnPass.Click += new System.EventHandler(this.btnLearnPass_Click);
            // 
            // pbSpeechText
            // 
            this.pbSpeechText.Location = new System.Drawing.Point(783, 290);
            this.pbSpeechText.Name = "pbSpeechText";
            this.pbSpeechText.Size = new System.Drawing.Size(35, 33);
            this.pbSpeechText.TabIndex = 9;
            this.pbSpeechText.TabStop = false;
            this.pbSpeechText.Click += new System.EventHandler(this.pbSpeechText_Click);
            // 
            // pbSpeechWord
            // 
            this.pbSpeechWord.Location = new System.Drawing.Point(459, 78);
            this.pbSpeechWord.Name = "pbSpeechWord";
            this.pbSpeechWord.Size = new System.Drawing.Size(40, 34);
            this.pbSpeechWord.TabIndex = 10;
            this.pbSpeechWord.TabStop = false;
            this.pbSpeechWord.Click += new System.EventHandler(this.pbSpeechWord_Click);
            // 
            // lblWordId
            // 
            this.lblWordId.AutoSize = true;
            this.lblWordId.Location = new System.Drawing.Point(13, 13);
            this.lblWordId.Name = "lblWordId";
            this.lblWordId.Size = new System.Drawing.Size(0, 17);
            this.lblWordId.TabIndex = 11;
            // 
            // frmLearnWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 441);
            this.Controls.Add(this.lblWordId);
            this.Controls.Add(this.pbSpeechWord);
            this.Controls.Add(this.pbSpeechText);
            this.Controls.Add(this.btnLearnPass);
            this.Controls.Add(this.txtToTurkish);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExSentence);
            this.Controls.Add(this.pbWordImage);
            this.Name = "frmLearnWord";
            this.Text = "Yeni Kelime Öğren";
            this.Load += new System.EventHandler(this.frmLearnWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeechText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeechWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWordImage;
        private System.Windows.Forms.RichTextBox txtExSentence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtToTurkish;
        private System.Windows.Forms.Button btnLearnPass;
        private System.Windows.Forms.PictureBox pbSpeechText;
        private System.Windows.Forms.PictureBox pbSpeechWord;
        private System.Windows.Forms.Label lblWordId;
    }
}