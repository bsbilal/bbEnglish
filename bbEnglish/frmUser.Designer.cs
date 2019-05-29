namespace bbEnglish
{
    partial class frmUser
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
            this.btnLearnWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLearnWord
            // 
            this.btnLearnWord.Location = new System.Drawing.Point(32, 92);
            this.btnLearnWord.Name = "btnLearnWord";
            this.btnLearnWord.Size = new System.Drawing.Size(259, 61);
            this.btnLearnWord.TabIndex = 0;
            this.btnLearnWord.Text = "Yeni Kelime Öğren";
            this.btnLearnWord.UseVisualStyleBackColor = true;
            this.btnLearnWord.Click += new System.EventHandler(this.btnLearnWord_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 198);
            this.Controls.Add(this.btnLearnWord);
            this.Name = "frmUser";
            this.Text = "te";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLearnWord;
    }
}