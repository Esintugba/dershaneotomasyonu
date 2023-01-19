namespace DershaneTakip
{
    partial class GirisCıkıs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisCıkıs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOgrenci = new System.Windows.Forms.TextBox();
            this.textBoxGiris = new System.Windows.Forms.TextBox();
            this.textBoxCikis = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBDershaneTakipDataSet2 = new DershaneTakip.DBDershaneTakipDataSet2();
            this.girisCikisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girisCikisTableAdapter = new DershaneTakip.DBDershaneTakipDataSet2TableAdapters.GirisCikisTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cıkısSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxSil = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuncelle = new System.Windows.Forms.PictureBox();
            this.pictureBoxKaydet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDershaneTakipDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisCikisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKaydet)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(642, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giriş  ve Çıkış Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(833, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 35);
            this.label12.TabIndex = 32;
            this.label12.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxID.Location = new System.Drawing.Point(925, 191);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(286, 36);
            this.textBoxID.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(294, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 35);
            this.label4.TabIndex = 58;
            this.label4.Text = "Öğrencinin Adı -Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1072, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 35);
            this.label2.TabIndex = 59;
            this.label2.Text = "Giriş Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1072, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 35);
            this.label3.TabIndex = 60;
            this.label3.Text = "Çıkış Saati:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(500, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 35);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tarih:";
            // 
            // textBoxOgrenci
            // 
            this.textBoxOgrenci.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOgrenci.Location = new System.Drawing.Point(637, 283);
            this.textBoxOgrenci.Name = "textBoxOgrenci";
            this.textBoxOgrenci.Size = new System.Drawing.Size(286, 36);
            this.textBoxOgrenci.TabIndex = 62;
            // 
            // textBoxGiris
            // 
            this.textBoxGiris.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGiris.Location = new System.Drawing.Point(1274, 271);
            this.textBoxGiris.Name = "textBoxGiris";
            this.textBoxGiris.Size = new System.Drawing.Size(286, 36);
            this.textBoxGiris.TabIndex = 63;
            // 
            // textBoxCikis
            // 
            this.textBoxCikis.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCikis.Location = new System.Drawing.Point(1274, 342);
            this.textBoxCikis.Name = "textBoxCikis";
            this.textBoxCikis.Size = new System.Drawing.Size(286, 36);
            this.textBoxCikis.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(637, 342);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 36);
            this.dateTimePicker1.TabIndex = 65;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.girisSaatDataGridViewTextBoxColumn,
            this.cıkısSaatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.ogrenciDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.girisCikisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(574, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(915, 451);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dBDershaneTakipDataSet2
            // 
            this.dBDershaneTakipDataSet2.DataSetName = "DBDershaneTakipDataSet2";
            this.dBDershaneTakipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // girisCikisBindingSource
            // 
            this.girisCikisBindingSource.DataMember = "GirisCikis";
            this.girisCikisBindingSource.DataSource = this.dBDershaneTakipDataSet2;
            // 
            // girisCikisTableAdapter
            // 
            this.girisCikisTableAdapter.ClearBeforeFill = true;
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
            // girisSaatDataGridViewTextBoxColumn
            // 
            this.girisSaatDataGridViewTextBoxColumn.DataPropertyName = "GirisSaat";
            this.girisSaatDataGridViewTextBoxColumn.HeaderText = "GirisSaat";
            this.girisSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girisSaatDataGridViewTextBoxColumn.Name = "girisSaatDataGridViewTextBoxColumn";
            this.girisSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // cıkısSaatDataGridViewTextBoxColumn
            // 
            this.cıkısSaatDataGridViewTextBoxColumn.DataPropertyName = "CıkısSaat";
            this.cıkısSaatDataGridViewTextBoxColumn.HeaderText = "CıkısSaat";
            this.cıkısSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cıkısSaatDataGridViewTextBoxColumn.Name = "cıkısSaatDataGridViewTextBoxColumn";
            this.cıkısSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciDataGridViewTextBoxColumn
            // 
            this.ogrenciDataGridViewTextBoxColumn.DataPropertyName = "Ogrenci";
            this.ogrenciDataGridViewTextBoxColumn.HeaderText = "Ogrenci";
            this.ogrenciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciDataGridViewTextBoxColumn.Name = "ogrenciDataGridViewTextBoxColumn";
            this.ogrenciDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureBoxSil
            // 
            this.pictureBoxSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSil.BackgroundImage")));
            this.pictureBoxSil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSil.Image")));
            this.pictureBoxSil.Location = new System.Drawing.Point(1605, 48);
            this.pictureBoxSil.Name = "pictureBoxSil";
            this.pictureBoxSil.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSil.TabIndex = 78;
            this.pictureBoxSil.TabStop = false;
            this.pictureBoxSil.Click += new System.EventHandler(this.pictureBoxSil_Click);
            // 
            // pictureBoxGuncelle
            // 
            this.pictureBoxGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuncelle.BackgroundImage")));
            this.pictureBoxGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuncelle.Image")));
            this.pictureBoxGuncelle.Location = new System.Drawing.Point(1695, 48);
            this.pictureBoxGuncelle.Name = "pictureBoxGuncelle";
            this.pictureBoxGuncelle.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuncelle.TabIndex = 79;
            this.pictureBoxGuncelle.TabStop = false;
            this.pictureBoxGuncelle.Click += new System.EventHandler(this.pictureBoxGuncelle_Click);
            // 
            // pictureBoxKaydet
            // 
            this.pictureBoxKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxKaydet.BackgroundImage")));
            this.pictureBoxKaydet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKaydet.Image")));
            this.pictureBoxKaydet.Location = new System.Drawing.Point(1776, 48);
            this.pictureBoxKaydet.Name = "pictureBoxKaydet";
            this.pictureBoxKaydet.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKaydet.TabIndex = 80;
            this.pictureBoxKaydet.TabStop = false;
            this.pictureBoxKaydet.Click += new System.EventHandler(this.pictureBoxKaydet_Click);
            // 
            // GirisCıkıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBoxKaydet);
            this.Controls.Add(this.pictureBoxGuncelle);
            this.Controls.Add(this.pictureBoxSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxCikis);
            this.Controls.Add(this.textBoxGiris);
            this.Controls.Add(this.textBoxOgrenci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GirisCıkıs";
            this.Text = "GirisCıkıs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GirisCıkıs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDershaneTakipDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisCikisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKaydet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOgrenci;
        private System.Windows.Forms.TextBox textBoxGiris;
        private System.Windows.Forms.TextBox textBoxCikis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDershaneTakipDataSet2 dBDershaneTakipDataSet2;
        private System.Windows.Forms.BindingSource girisCikisBindingSource;
        private DBDershaneTakipDataSet2TableAdapters.GirisCikisTableAdapter girisCikisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cıkısSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBoxSil;
        private System.Windows.Forms.PictureBox pictureBoxGuncelle;
        private System.Windows.Forms.PictureBox pictureBoxKaydet;
    }
}