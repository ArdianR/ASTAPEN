namespace ASTAPEN
{
    partial class menuutama
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.olahDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olahPendudukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formPelaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formKematianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formKelahiranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formKKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penyuratanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suratPengantarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suratKeteranganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penduduk_ttp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pilihGrafik = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbLahirMati = new System.Windows.Forms.ComboBox();
            this.ChartKelahiranKematian = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kependudukanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kependudukanDataSet = new ASTAPEN.kependudukanDataSet();
            this.pelaporBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pelaporBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pelaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelaporTableAdapter = new ASTAPEN.kependudukanDataSetTableAdapters.pelaporTableAdapter();
            this.pendudukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pendudukTableAdapter = new ASTAPEN.kependudukanDataSetTableAdapters.pendudukTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.penduduk_ttp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartKelahiranKematian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kependudukanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kependudukanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaporBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaporBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendudukBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.olahDataToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.penyuratanToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(790, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // olahDataToolStripMenuItem
            // 
            this.olahDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.olahPendudukToolStripMenuItem,
            this.formPelaporToolStripMenuItem,
            this.formKematianToolStripMenuItem,
            this.formKelahiranToolStripMenuItem,
            this.formKKToolStripMenuItem,
            this.formAdminToolStripMenuItem});
            this.olahDataToolStripMenuItem.Name = "olahDataToolStripMenuItem";
            this.olahDataToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.olahDataToolStripMenuItem.Text = "Olah Data";
            // 
            // olahPendudukToolStripMenuItem
            // 
            this.olahPendudukToolStripMenuItem.Name = "olahPendudukToolStripMenuItem";
            this.olahPendudukToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.olahPendudukToolStripMenuItem.Text = "Olah Penduduk";
            this.olahPendudukToolStripMenuItem.Click += new System.EventHandler(this.olahPendudukToolStripMenuItem_Click);
            // 
            // formPelaporToolStripMenuItem
            // 
            this.formPelaporToolStripMenuItem.Name = "formPelaporToolStripMenuItem";
            this.formPelaporToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.formPelaporToolStripMenuItem.Text = "Form Pelapor";
            this.formPelaporToolStripMenuItem.Click += new System.EventHandler(this.formPelaporToolStripMenuItem_Click);
            // 
            // formKematianToolStripMenuItem
            // 
            this.formKematianToolStripMenuItem.Name = "formKematianToolStripMenuItem";
            this.formKematianToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.formKematianToolStripMenuItem.Text = "Form Kematian";
            this.formKematianToolStripMenuItem.Click += new System.EventHandler(this.formKematianToolStripMenuItem_Click);
            // 
            // formKelahiranToolStripMenuItem
            // 
            this.formKelahiranToolStripMenuItem.Name = "formKelahiranToolStripMenuItem";
            this.formKelahiranToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.formKelahiranToolStripMenuItem.Text = "Form Kelahiran";
            this.formKelahiranToolStripMenuItem.Click += new System.EventHandler(this.formKelahiranToolStripMenuItem_Click);
            // 
            // formKKToolStripMenuItem
            // 
            this.formKKToolStripMenuItem.Name = "formKKToolStripMenuItem";
            this.formKKToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.formKKToolStripMenuItem.Text = "Form KK";
            this.formKKToolStripMenuItem.Click += new System.EventHandler(this.formKKToolStripMenuItem_Click);
            // 
            // formAdminToolStripMenuItem
            // 
            this.formAdminToolStripMenuItem.Name = "formAdminToolStripMenuItem";
            this.formAdminToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.formAdminToolStripMenuItem.Text = "Form Admin";
            this.formAdminToolStripMenuItem.Click += new System.EventHandler(this.formAdminToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // penyuratanToolStripMenuItem
            // 
            this.penyuratanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suratPengantarToolStripMenuItem,
            this.suratKeteranganToolStripMenuItem});
            this.penyuratanToolStripMenuItem.Name = "penyuratanToolStripMenuItem";
            this.penyuratanToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.penyuratanToolStripMenuItem.Text = "Penyuratan";
            // 
            // suratPengantarToolStripMenuItem
            // 
            this.suratPengantarToolStripMenuItem.Name = "suratPengantarToolStripMenuItem";
            this.suratPengantarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.suratPengantarToolStripMenuItem.Text = "Surat Pengantar";
            // 
            // suratKeteranganToolStripMenuItem
            // 
            this.suratKeteranganToolStripMenuItem.Name = "suratKeteranganToolStripMenuItem";
            this.suratKeteranganToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.suratKeteranganToolStripMenuItem.Text = "Surat Keterangan";
            // 
            // penduduk_ttp
            // 
            this.penduduk_ttp.Controls.Add(this.tabPage1);
            this.penduduk_ttp.Controls.Add(this.tabPage2);
            this.penduduk_ttp.Controls.Add(this.tabPage4);
            this.penduduk_ttp.Location = new System.Drawing.Point(12, 51);
            this.penduduk_ttp.Name = "penduduk_ttp";
            this.penduduk_ttp.SelectedIndex = 0;
            this.penduduk_ttp.Size = new System.Drawing.Size(766, 379);
            this.penduduk_ttp.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pilihGrafik);
            this.tabPage1.Controls.Add(this.chart2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Penduduk Tetap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pilihGrafik
            // 
            this.pilihGrafik.FormattingEnabled = true;
            this.pilihGrafik.Items.AddRange(new object[] {
            "RT",
            "Jenis Kelamin",
            "Umur",
            "Pekerjaan"});
            this.pilihGrafik.Location = new System.Drawing.Point(511, 19);
            this.pilihGrafik.Name = "pilihGrafik";
            this.pilihGrafik.Size = new System.Drawing.Size(228, 21);
            this.pilihGrafik.TabIndex = 5;
            this.pilihGrafik.SelectedIndexChanged += new System.EventHandler(this.pilihGrafik_SelectedIndexChanged_1);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(6, 36);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Jumlah Penduduk";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Laki-laki";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Perempuan";
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Pekerjaan";
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(749, 287);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Penduduk Pelapor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbLahirMati);
            this.tabPage4.Controls.Add(this.ChartKelahiranKematian);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(758, 353);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kelahiran dan Kematian";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbLahirMati
            // 
            this.cmbLahirMati.FormattingEnabled = true;
            this.cmbLahirMati.Location = new System.Drawing.Point(592, 3);
            this.cmbLahirMati.Name = "cmbLahirMati";
            this.cmbLahirMati.Size = new System.Drawing.Size(121, 21);
            this.cmbLahirMati.TabIndex = 2;
            this.cmbLahirMati.SelectedIndexChanged += new System.EventHandler(this.cmbLahirMati_SelectedIndexChanged);
            // 
            // ChartKelahiranKematian
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartKelahiranKematian.ChartAreas.Add(chartArea3);
            legend2.Name = "Legend1";
            this.ChartKelahiranKematian.Legends.Add(legend2);
            this.ChartKelahiranKematian.Location = new System.Drawing.Point(45, 43);
            this.ChartKelahiranKematian.Name = "ChartKelahiranKematian";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "Kelahiran Kematian";
            this.ChartKelahiranKematian.Series.Add(series5);
            this.ChartKelahiranKematian.Size = new System.Drawing.Size(668, 267);
            this.ChartKelahiranKematian.TabIndex = 1;
            this.ChartKelahiranKematian.Text = "chart1";
            // 
            // kependudukanDataSetBindingSource
            // 
            this.kependudukanDataSetBindingSource.DataSource = this.kependudukanDataSet;
            this.kependudukanDataSetBindingSource.Position = 0;
            // 
            // kependudukanDataSet
            // 
            this.kependudukanDataSet.DataSetName = "kependudukanDataSet";
            this.kependudukanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pelaporBindingSource2
            // 
            this.pelaporBindingSource2.DataMember = "pelapor";
            this.pelaporBindingSource2.DataSource = this.kependudukanDataSetBindingSource;
            // 
            // pelaporBindingSource1
            // 
            this.pelaporBindingSource1.DataMember = "pelapor";
            this.pelaporBindingSource1.DataSource = this.kependudukanDataSet;
            // 
            // pelaporBindingSource
            // 
            this.pelaporBindingSource.DataMember = "pelapor";
            this.pelaporBindingSource.DataSource = this.kependudukanDataSet;
            // 
            // pelaporTableAdapter
            // 
            this.pelaporTableAdapter.ClearBeforeFill = true;
            // 
            // pendudukBindingSource
            // 
            this.pendudukBindingSource.DataMember = "penduduk";
            this.pendudukBindingSource.DataSource = this.kependudukanDataSet;
            // 
            // pendudukTableAdapter
            // 
            this.pendudukTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuutama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.penduduk_ttp);
            this.Controls.Add(this.menuStrip2);
            this.Name = "menuutama";
            this.Text = "menuutama";
            this.Load += new System.EventHandler(this.menuutama_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.penduduk_ttp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartKelahiranKematian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kependudukanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kependudukanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaporBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaporBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendudukBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem olahDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem olahPendudukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formPelaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formKematianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formKelahiranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formKKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penyuratanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suratPengantarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suratKeteranganToolStripMenuItem;
        private System.Windows.Forms.TabControl penduduk_ttp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private kependudukanDataSet kependudukanDataSet;
        private System.Windows.Forms.BindingSource pelaporBindingSource;
        private kependudukanDataSetTableAdapters.pelaporTableAdapter pelaporTableAdapter;
        private System.Windows.Forms.BindingSource pelaporBindingSource1;
        private System.Windows.Forms.BindingSource pelaporBindingSource2;
        private System.Windows.Forms.BindingSource kependudukanDataSetBindingSource;
        private System.Windows.Forms.BindingSource pendudukBindingSource;
        private kependudukanDataSetTableAdapters.pendudukTableAdapter pendudukTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox pilihGrafik;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartKelahiranKematian;
        private System.Windows.Forms.ComboBox cmbLahirMati;
        private System.Windows.Forms.Button button1;
        
    }
}