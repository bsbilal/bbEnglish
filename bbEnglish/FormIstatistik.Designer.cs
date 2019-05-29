namespace bbEnglish
{
    partial class FormIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafikOgrenilenKelime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbUyeler = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grafikPastaTum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbYillar = new MetroFramework.Controls.MetroComboBox();
            this.grpYilIstatistik = new System.Windows.Forms.GroupBox();
            this.lblToplam = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grafikOgrenilenKelime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikPastaTum)).BeginInit();
            this.grpYilIstatistik.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafikOgrenilenKelime
            // 
            chartArea7.Name = "ChartArea1";
            this.grafikOgrenilenKelime.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.grafikOgrenilenKelime.Legends.Add(legend7);
            this.grafikOgrenilenKelime.Location = new System.Drawing.Point(6, 83);
            this.grafikOgrenilenKelime.Name = "grafikOgrenilenKelime";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Öğrenilen Kelime";
            this.grafikOgrenilenKelime.Series.Add(series7);
            this.grafikOgrenilenKelime.Size = new System.Drawing.Size(471, 405);
            this.grafikOgrenilenKelime.TabIndex = 0;
            this.grafikOgrenilenKelime.Text = "chart1";
            this.grafikOgrenilenKelime.Click += new System.EventHandler(this.grafikOgrenilenKelime_Click);
            // 
            // cmbUyeler
            // 
            this.cmbUyeler.FormattingEnabled = true;
            this.cmbUyeler.ItemHeight = 24;
            this.cmbUyeler.Location = new System.Drawing.Point(20, 137);
            this.cmbUyeler.Name = "cmbUyeler";
            this.cmbUyeler.Size = new System.Drawing.Size(226, 30);
            this.cmbUyeler.TabIndex = 1;
            this.cmbUyeler.UseSelectable = true;
            this.cmbUyeler.SelectedIndexChanged += new System.EventHandler(this.cmbUyeler_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(46, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(291, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Öğrendiği Kelime Sayısı Ay Bazında";
            // 
            // grafikPastaTum
            // 
            chartArea8.Name = "ChartArea1";
            this.grafikPastaTum.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.grafikPastaTum.Legends.Add(legend8);
            this.grafikPastaTum.Location = new System.Drawing.Point(20, 216);
            this.grafikPastaTum.Name = "grafikPastaTum";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Kelimeler";
            this.grafikPastaTum.Series.Add(series8);
            this.grafikPastaTum.Size = new System.Drawing.Size(339, 254);
            this.grafikPastaTum.TabIndex = 3;
            this.grafikPastaTum.Text = "chart1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(1, 188);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(311, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Tüm Kelimelere göre öğrenme grafiği";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(11, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Üye Seçin";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(18, 26);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Yıl Seçin";
            // 
            // cmbYillar
            // 
            this.cmbYillar.FormattingEnabled = true;
            this.cmbYillar.ItemHeight = 24;
            this.cmbYillar.Location = new System.Drawing.Point(121, 21);
            this.cmbYillar.Name = "cmbYillar";
            this.cmbYillar.Size = new System.Drawing.Size(126, 30);
            this.cmbYillar.TabIndex = 6;
            this.cmbYillar.UseSelectable = true;
            this.cmbYillar.SelectedIndexChanged += new System.EventHandler(this.cmbYillar_SelectedIndexChanged);
            // 
            // grpYilIstatistik
            // 
            this.grpYilIstatistik.Controls.Add(this.metroLabel1);
            this.grpYilIstatistik.Controls.Add(this.metroLabel4);
            this.grpYilIstatistik.Controls.Add(this.grafikOgrenilenKelime);
            this.grpYilIstatistik.Controls.Add(this.cmbYillar);
            this.grpYilIstatistik.Location = new System.Drawing.Point(389, 44);
            this.grpYilIstatistik.Name = "grpYilIstatistik";
            this.grpYilIstatistik.Size = new System.Drawing.Size(500, 488);
            this.grpYilIstatistik.TabIndex = 8;
            this.grpYilIstatistik.TabStop = false;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(20, 522);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 0);
            this.lblToplam.TabIndex = 9;
            // 
            // FormIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 560);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.grpYilIstatistik);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.grafikPastaTum);
            this.Controls.Add(this.cmbUyeler);
            this.Name = "FormIstatistik";
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.FormIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafikOgrenilenKelime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikPastaTum)).EndInit();
            this.grpYilIstatistik.ResumeLayout(false);
            this.grpYilIstatistik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafikOgrenilenKelime;
        private MetroFramework.Controls.MetroComboBox cmbUyeler;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafikPastaTum;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbYillar;
        private System.Windows.Forms.GroupBox grpYilIstatistik;
        private MetroFramework.Controls.MetroLabel lblToplam;
    }
}