namespace DershaneTakip
{
    partial class OgretmenKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenKayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextTc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDogumYeri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDershaneTakipDataSetOgretmen = new DershaneTakip.DBDershaneTakipDataSetOgretmen();
            this.ogretmenTableAdapter = new DershaneTakip.DBDershaneTakipDataSetOgretmenTableAdapters.OgretmenTableAdapter();
            this.pictureBoxSil = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuncelle = new System.Windows.Forms.PictureBox();
            this.pictureBoxKaydet = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDershaneTakipDataSetOgretmen)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(839, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğretmen Kayıt Formu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(242, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 35);
            this.label12.TabIndex = 29;
            this.label12.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxID.Location = new System.Drawing.Point(331, 216);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(286, 36);
            this.textBoxID.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(228, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 35);
            this.label2.TabIndex = 31;
            this.label2.Text = "T.C :";
            // 
            // maskedTextTc
            // 
            this.maskedTextTc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextTc.Location = new System.Drawing.Point(331, 286);
            this.maskedTextTc.Mask = "00000000000";
            this.maskedTextTc.Name = "maskedTextTc";
            this.maskedTextTc.Size = new System.Drawing.Size(286, 36);
            this.maskedTextTc.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(228, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 35);
            this.label4.TabIndex = 33;
            this.label4.Text = "Adı:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(331, 361);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(286, 36);
            this.textBoxAd.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(191, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.TabIndex = 35;
            this.label5.Text = "Soyadı:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(331, 440);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(286, 36);
            this.textBoxSoyad.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(113, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 35);
            this.label6.TabIndex = 37;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 521);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 36);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(134, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 35);
            this.label7.TabIndex = 39;
            this.label7.Text = "Doğum Yeri:";
            // 
            // textBoxDogumYeri
            // 
            this.textBoxDogumYeri.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDogumYeri.Location = new System.Drawing.Point(331, 604);
            this.textBoxDogumYeri.Name = "textBoxDogumYeri";
            this.textBoxDogumYeri.Size = new System.Drawing.Size(286, 36);
            this.textBoxDogumYeri.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(194, 678);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 35);
            this.label8.TabIndex = 41;
            this.label8.Text = "E-Mail:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMail.Location = new System.Drawing.Point(331, 677);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(286, 36);
            this.textBoxMail.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(143, 758);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 35);
            this.label9.TabIndex = 43;
            this.label9.Text = "Telefon No:";
            // 
            // maskedTextTelefon
            // 
            this.maskedTextTelefon.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextTelefon.Location = new System.Drawing.Point(331, 757);
            this.maskedTextTelefon.Mask = "(999) 000-0000";
            this.maskedTextTelefon.Name = "maskedTextTelefon";
            this.maskedTextTelefon.Size = new System.Drawing.Size(286, 36);
            this.maskedTextTelefon.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(215, 897);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 35);
            this.label3.TabIndex = 45;
            this.label3.Text = "Şifre:";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(331, 898);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(286, 36);
            this.textBoxSifre.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.dogumYeriDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.bransDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogretmenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(680, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 650);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            this.dogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumYeriDataGridViewTextBoxColumn
            // 
            this.dogumYeriDataGridViewTextBoxColumn.DataPropertyName = "DogumYeri";
            this.dogumYeriDataGridViewTextBoxColumn.HeaderText = "DogumYeri";
            this.dogumYeriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumYeriDataGridViewTextBoxColumn.Name = "dogumYeriDataGridViewTextBoxColumn";
            this.dogumYeriDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bransDataGridViewTextBoxColumn
            // 
            this.bransDataGridViewTextBoxColumn.DataPropertyName = "Brans";
            this.bransDataGridViewTextBoxColumn.HeaderText = "Brans";
            this.bransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bransDataGridViewTextBoxColumn.Name = "bransDataGridViewTextBoxColumn";
            this.bransDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogretmenBindingSource
            // 
            this.ogretmenBindingSource.DataMember = "Ogretmen";
            this.ogretmenBindingSource.DataSource = this.dBDershaneTakipDataSetOgretmen;
            // 
            // dBDershaneTakipDataSetOgretmen
            // 
            this.dBDershaneTakipDataSetOgretmen.DataSetName = "DBDershaneTakipDataSetOgretmen";
            this.dBDershaneTakipDataSetOgretmen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogretmenTableAdapter
            // 
            this.ogretmenTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBoxSil
            // 
            this.pictureBoxSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSil.BackgroundImage")));
            this.pictureBoxSil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSil.Image")));
            this.pictureBoxSil.Location = new System.Drawing.Point(1643, 34);
            this.pictureBoxSil.Name = "pictureBoxSil";
            this.pictureBoxSil.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSil.TabIndex = 48;
            this.pictureBoxSil.TabStop = false;
            this.pictureBoxSil.Click += new System.EventHandler(this.pictureBoxSil_Click);
            // 
            // pictureBoxGuncelle
            // 
            this.pictureBoxGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuncelle.BackgroundImage")));
            this.pictureBoxGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuncelle.Image")));
            this.pictureBoxGuncelle.Location = new System.Drawing.Point(1724, 34);
            this.pictureBoxGuncelle.Name = "pictureBoxGuncelle";
            this.pictureBoxGuncelle.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuncelle.TabIndex = 49;
            this.pictureBoxGuncelle.TabStop = false;
            this.pictureBoxGuncelle.Click += new System.EventHandler(this.pictureBoxGuncelle_Click);
            // 
            // pictureBoxKaydet
            // 
            this.pictureBoxKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxKaydet.BackgroundImage")));
            this.pictureBoxKaydet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKaydet.Image")));
            this.pictureBoxKaydet.Location = new System.Drawing.Point(1800, 34);
            this.pictureBoxKaydet.Name = "pictureBoxKaydet";
            this.pictureBoxKaydet.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKaydet.TabIndex = 50;
            this.pictureBoxKaydet.TabStop = false;
            this.pictureBoxKaydet.Click += new System.EventHandler(this.pictureBoxKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(177, 831);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 35);
            this.label10.TabIndex = 51;
            this.label10.Text = "Branşı:";
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Items.AddRange(new object[] {
            "Matematik",
            "Kimya",
            "Türkçe",
            "Felsefe",
            "Fizik",
            "Tarih",
            "Biyoloji",
            "Geometri",
            "Edebiyat",
            "Coğrafya",
            "Psikoloji",
            "Din Kültürü",
            "İngilizce",
            "Fransızca",
            "Almanca",
            "Müzik",
            "Resim",
            "Beden Eğitimi",
            "Rehberlik"});
            this.comboBoxBrans.Location = new System.Drawing.Point(331, 830);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(286, 36);
            this.comboBoxBrans.TabIndex = 52;
            // 
            // OgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.comboBoxBrans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBoxKaydet);
            this.Controls.Add(this.pictureBoxGuncelle);
            this.Controls.Add(this.pictureBoxSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextTelefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDogumYeri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OgretmenKayit";
            this.Text = "Ögretmen Kayıt Formu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OgretmenKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDershaneTakipDataSetOgretmen)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDogumYeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDershaneTakipDataSetOgretmen dBDershaneTakipDataSetOgretmen;
        private System.Windows.Forms.BindingSource ogretmenBindingSource;
        private DBDershaneTakipDataSetOgretmenTableAdapters.OgretmenTableAdapter ogretmenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBoxSil;
        private System.Windows.Forms.PictureBox pictureBoxGuncelle;
        private System.Windows.Forms.PictureBox pictureBoxKaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxBrans;
    }
}