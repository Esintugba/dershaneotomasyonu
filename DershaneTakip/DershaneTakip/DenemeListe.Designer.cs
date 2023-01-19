namespace DershaneTakip
{
    partial class DenemeListe
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DenemeListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biyolojiNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizikNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimyaNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cografyaNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turkceNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matematikNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felsefeNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edebiyatNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geometriNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denemeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denemePuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDershaneTakipDataSet3 = new DershaneTakip.DBDershaneTakipDataSet3();
            this.denemelerTableAdapter = new DershaneTakip.DBDershaneTakipDataSet3TableAdapters.DenemelerTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDershaneTakipDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.ogrenciDataGridViewTextBoxColumn,
            this.biyolojiNetDataGridViewTextBoxColumn,
            this.fizikNetDataGridViewTextBoxColumn,
            this.kimyaNetDataGridViewTextBoxColumn,
            this.cografyaNetDataGridViewTextBoxColumn,
            this.turkceNetDataGridViewTextBoxColumn,
            this.tarihNetDataGridViewTextBoxColumn,
            this.matematikNetDataGridViewTextBoxColumn,
            this.felsefeNetDataGridViewTextBoxColumn,
            this.edebiyatNetDataGridViewTextBoxColumn,
            this.geometriNetDataGridViewTextBoxColumn,
            this.denemeNoDataGridViewTextBoxColumn,
            this.denemePuanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.denemelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(98, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 825);
            this.dataGridView1.TabIndex = 1;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciDataGridViewTextBoxColumn
            // 
            this.ogrenciDataGridViewTextBoxColumn.DataPropertyName = "Ogrenci";
            this.ogrenciDataGridViewTextBoxColumn.HeaderText = "Ogrenci";
            this.ogrenciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciDataGridViewTextBoxColumn.Name = "ogrenciDataGridViewTextBoxColumn";
            this.ogrenciDataGridViewTextBoxColumn.Width = 125;
            // 
            // biyolojiNetDataGridViewTextBoxColumn
            // 
            this.biyolojiNetDataGridViewTextBoxColumn.DataPropertyName = "BiyolojiNet";
            this.biyolojiNetDataGridViewTextBoxColumn.HeaderText = "BiyolojiNet";
            this.biyolojiNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biyolojiNetDataGridViewTextBoxColumn.Name = "biyolojiNetDataGridViewTextBoxColumn";
            this.biyolojiNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // fizikNetDataGridViewTextBoxColumn
            // 
            this.fizikNetDataGridViewTextBoxColumn.DataPropertyName = "FizikNet";
            this.fizikNetDataGridViewTextBoxColumn.HeaderText = "FizikNet";
            this.fizikNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fizikNetDataGridViewTextBoxColumn.Name = "fizikNetDataGridViewTextBoxColumn";
            this.fizikNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // kimyaNetDataGridViewTextBoxColumn
            // 
            this.kimyaNetDataGridViewTextBoxColumn.DataPropertyName = "KimyaNet";
            this.kimyaNetDataGridViewTextBoxColumn.HeaderText = "KimyaNet";
            this.kimyaNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kimyaNetDataGridViewTextBoxColumn.Name = "kimyaNetDataGridViewTextBoxColumn";
            this.kimyaNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // cografyaNetDataGridViewTextBoxColumn
            // 
            this.cografyaNetDataGridViewTextBoxColumn.DataPropertyName = "CografyaNet";
            this.cografyaNetDataGridViewTextBoxColumn.HeaderText = "CografyaNet";
            this.cografyaNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cografyaNetDataGridViewTextBoxColumn.Name = "cografyaNetDataGridViewTextBoxColumn";
            this.cografyaNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // turkceNetDataGridViewTextBoxColumn
            // 
            this.turkceNetDataGridViewTextBoxColumn.DataPropertyName = "TurkceNet";
            this.turkceNetDataGridViewTextBoxColumn.HeaderText = "TurkceNet";
            this.turkceNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turkceNetDataGridViewTextBoxColumn.Name = "turkceNetDataGridViewTextBoxColumn";
            this.turkceNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihNetDataGridViewTextBoxColumn
            // 
            this.tarihNetDataGridViewTextBoxColumn.DataPropertyName = "TarihNet";
            this.tarihNetDataGridViewTextBoxColumn.HeaderText = "TarihNet";
            this.tarihNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihNetDataGridViewTextBoxColumn.Name = "tarihNetDataGridViewTextBoxColumn";
            this.tarihNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // matematikNetDataGridViewTextBoxColumn
            // 
            this.matematikNetDataGridViewTextBoxColumn.DataPropertyName = "MatematikNet";
            this.matematikNetDataGridViewTextBoxColumn.HeaderText = "MatematikNet";
            this.matematikNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matematikNetDataGridViewTextBoxColumn.Name = "matematikNetDataGridViewTextBoxColumn";
            this.matematikNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // felsefeNetDataGridViewTextBoxColumn
            // 
            this.felsefeNetDataGridViewTextBoxColumn.DataPropertyName = "FelsefeNet";
            this.felsefeNetDataGridViewTextBoxColumn.HeaderText = "FelsefeNet";
            this.felsefeNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.felsefeNetDataGridViewTextBoxColumn.Name = "felsefeNetDataGridViewTextBoxColumn";
            this.felsefeNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // edebiyatNetDataGridViewTextBoxColumn
            // 
            this.edebiyatNetDataGridViewTextBoxColumn.DataPropertyName = "EdebiyatNet";
            this.edebiyatNetDataGridViewTextBoxColumn.HeaderText = "EdebiyatNet";
            this.edebiyatNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edebiyatNetDataGridViewTextBoxColumn.Name = "edebiyatNetDataGridViewTextBoxColumn";
            this.edebiyatNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // geometriNetDataGridViewTextBoxColumn
            // 
            this.geometriNetDataGridViewTextBoxColumn.DataPropertyName = "GeometriNet";
            this.geometriNetDataGridViewTextBoxColumn.HeaderText = "GeometriNet";
            this.geometriNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.geometriNetDataGridViewTextBoxColumn.Name = "geometriNetDataGridViewTextBoxColumn";
            this.geometriNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // denemeNoDataGridViewTextBoxColumn
            // 
            this.denemeNoDataGridViewTextBoxColumn.DataPropertyName = "DenemeNo";
            this.denemeNoDataGridViewTextBoxColumn.HeaderText = "DenemeNo";
            this.denemeNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denemeNoDataGridViewTextBoxColumn.Name = "denemeNoDataGridViewTextBoxColumn";
            this.denemeNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // denemePuanDataGridViewTextBoxColumn
            // 
            this.denemePuanDataGridViewTextBoxColumn.DataPropertyName = "DenemePuan";
            this.denemePuanDataGridViewTextBoxColumn.HeaderText = "DenemePuan";
            this.denemePuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denemePuanDataGridViewTextBoxColumn.Name = "denemePuanDataGridViewTextBoxColumn";
            this.denemePuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // denemelerBindingSource
            // 
            this.denemelerBindingSource.DataMember = "Denemeler";
            this.denemelerBindingSource.DataSource = this.dBDershaneTakipDataSet3;
            // 
            // dBDershaneTakipDataSet3
            // 
            this.dBDershaneTakipDataSet3.DataSetName = "DBDershaneTakipDataSet3";
            this.dBDershaneTakipDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // denemelerTableAdapter
            // 
            this.denemelerTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1134, 250);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Puan";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(754, 557);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 1055);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DenemeListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DenemeListe";
            this.Text = "Deneme Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DenemeListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDershaneTakipDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDershaneTakipDataSet3 dBDershaneTakipDataSet3;
        private System.Windows.Forms.BindingSource denemelerBindingSource;
        private DBDershaneTakipDataSet3TableAdapters.DenemelerTableAdapter denemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biyolojiNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fizikNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimyaNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cografyaNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turkceNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matematikNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felsefeNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edebiyatNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geometriNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denemeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denemePuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}