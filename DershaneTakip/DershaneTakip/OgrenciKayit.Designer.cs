namespace DershaneTakip
{
    partial class OgrenciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciKayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxDogumYeri = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxVeli = new System.Windows.Forms.TextBox();
            this.maskedTextTelefon = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDershaneTakipDataSetOgrenci = new DershaneTakip.DBDershaneTakipDataSetOgrenci();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.ogrenciTableAdapter = new DershaneTakip.DBDershaneTakipDataSetOgrenciTableAdapters.OgrenciTableAdapter();
            this.pictureBoxGuncelle = new System.Windows.Forms.PictureBox();
            this.pictureBoxKaydet = new System.Windows.Forms.PictureBox();
            this.pictureBoxSil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDershaneTakipDataSetOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSil)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(808, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Kayıt Formu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "T.C :";
            // 
            // maskedTextTc
            // 
            this.maskedTextTc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextTc.Location = new System.Drawing.Point(265, 221);
            this.maskedTextTc.Mask = "00000000000";
            this.maskedTextTc.Name = "maskedTextTc";
            this.maskedTextTc.Size = new System.Drawing.Size(286, 36);
            this.maskedTextTc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(163, 900);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(173, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(139, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(61, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(82, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 35);
            this.label7.TabIndex = 11;
            this.label7.Text = "Doğum Yeri:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(142, 593);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 35);
            this.label8.TabIndex = 12;
            this.label8.Text = "E-Mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(91, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 35);
            this.label9.TabIndex = 13;
            this.label9.Text = "Telefon No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(122, 748);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 35);
            this.label10.TabIndex = 14;
            this.label10.Text = "Bölümü:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(151, 821);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 35);
            this.label11.TabIndex = 15;
            this.label11.Text = "Velisi:";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(265, 901);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(286, 36);
            this.textBoxSifre.TabIndex = 16;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(265, 292);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(286, 36);
            this.textBoxAd.TabIndex = 17;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(265, 370);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(286, 36);
            this.textBoxSoyad.TabIndex = 18;
            // 
            // textBoxDogumYeri
            // 
            this.textBoxDogumYeri.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDogumYeri.Location = new System.Drawing.Point(265, 521);
            this.textBoxDogumYeri.Name = "textBoxDogumYeri";
            this.textBoxDogumYeri.Size = new System.Drawing.Size(286, 36);
            this.textBoxDogumYeri.TabIndex = 19;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMail.Location = new System.Drawing.Point(265, 594);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(286, 36);
            this.textBoxMail.TabIndex = 20;
            // 
            // textBoxVeli
            // 
            this.textBoxVeli.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVeli.Location = new System.Drawing.Point(265, 822);
            this.textBoxVeli.Name = "textBoxVeli";
            this.textBoxVeli.Size = new System.Drawing.Size(286, 36);
            this.textBoxVeli.TabIndex = 23;
            // 
            // maskedTextTelefon
            // 
            this.maskedTextTelefon.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextTelefon.Location = new System.Drawing.Point(265, 670);
            this.maskedTextTelefon.Mask = "(999) 000-0000";
            this.maskedTextTelefon.Name = "maskedTextTelefon";
            this.maskedTextTelefon.Size = new System.Drawing.Size(286, 36);
            this.maskedTextTelefon.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 444);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 36);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Items.AddRange(new object[] {
            "Sayısal",
            "Sözel",
            "Eşit Ağırlık",
            "Yabancı Dil ",
            "Besyo"});
            this.comboBoxBolum.Location = new System.Drawing.Point(265, 749);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(286, 36);
            this.comboBoxBolum.TabIndex = 26;
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
            this.dogumtarihiDataGridViewTextBoxColumn,
            this.dogumyeriDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.bölümDataGridViewTextBoxColumn,
            this.veliDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(635, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 614);
            this.dataGridView1.TabIndex = 27;
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
            // dogumtarihiDataGridViewTextBoxColumn
            // 
            this.dogumtarihiDataGridViewTextBoxColumn.DataPropertyName = "Dogumtarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.HeaderText = "Dogumtarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumtarihiDataGridViewTextBoxColumn.Name = "dogumtarihiDataGridViewTextBoxColumn";
            this.dogumtarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumyeriDataGridViewTextBoxColumn
            // 
            this.dogumyeriDataGridViewTextBoxColumn.DataPropertyName = "Dogumyeri";
            this.dogumyeriDataGridViewTextBoxColumn.HeaderText = "Dogumyeri";
            this.dogumyeriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumyeriDataGridViewTextBoxColumn.Name = "dogumyeriDataGridViewTextBoxColumn";
            this.dogumyeriDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            this.bölümDataGridViewTextBoxColumn.DataPropertyName = "Bölüm";
            this.bölümDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.bölümDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            this.bölümDataGridViewTextBoxColumn.Width = 125;
            // 
            // veliDataGridViewTextBoxColumn
            // 
            this.veliDataGridViewTextBoxColumn.DataPropertyName = "Veli";
            this.veliDataGridViewTextBoxColumn.HeaderText = "Veli";
            this.veliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliDataGridViewTextBoxColumn.Name = "veliDataGridViewTextBoxColumn";
            this.veliDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.dBDershaneTakipDataSetOgrenci;
            // 
            // dBDershaneTakipDataSetOgrenci
            // 
            this.dBDershaneTakipDataSetOgrenci.DataSetName = "DBDershaneTakipDataSetOgrenci";
            this.dBDershaneTakipDataSetOgrenci.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(188, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 35);
            this.label12.TabIndex = 28;
            this.label12.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxID.Location = new System.Drawing.Point(265, 148);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(286, 36);
            this.textBoxID.TabIndex = 29;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBoxGuncelle
            // 
            this.pictureBoxGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuncelle.BackgroundImage")));
            this.pictureBoxGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuncelle.Image")));
            this.pictureBoxGuncelle.Location = new System.Drawing.Point(1722, 25);
            this.pictureBoxGuncelle.Name = "pictureBoxGuncelle";
            this.pictureBoxGuncelle.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuncelle.TabIndex = 30;
            this.pictureBoxGuncelle.TabStop = false;
            this.pictureBoxGuncelle.Click += new System.EventHandler(this.pictureBoxGuncelle_Click);
            // 
            // pictureBoxKaydet
            // 
            this.pictureBoxKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxKaydet.BackgroundImage")));
            this.pictureBoxKaydet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKaydet.Image")));
            this.pictureBoxKaydet.Location = new System.Drawing.Point(1797, 25);
            this.pictureBoxKaydet.Name = "pictureBoxKaydet";
            this.pictureBoxKaydet.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKaydet.TabIndex = 31;
            this.pictureBoxKaydet.TabStop = false;
            this.pictureBoxKaydet.Click += new System.EventHandler(this.pictureBoxKaydet_Click);
            // 
            // pictureBoxSil
            // 
            this.pictureBoxSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSil.BackgroundImage")));
            this.pictureBoxSil.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSil.Image")));
            this.pictureBoxSil.Location = new System.Drawing.Point(1646, 25);
            this.pictureBoxSil.Name = "pictureBoxSil";
            this.pictureBoxSil.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSil.TabIndex = 32;
            this.pictureBoxSil.TabStop = false;
            this.pictureBoxSil.Click += new System.EventHandler(this.pictureBoxSil_Click);
            // 
            // OgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBoxSil);
            this.Controls.Add(this.pictureBoxKaydet);
            this.Controls.Add(this.pictureBoxGuncelle);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxBolum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedTextTelefon);
            this.Controls.Add(this.textBoxVeli);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxDogumYeri);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OgrenciKayit";
            this.Text = "Öğrenci Kayıt Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OgrenciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDershaneTakipDataSetOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxDogumYeri;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxVeli;
        private System.Windows.Forms.MaskedTextBox maskedTextTelefon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxID;
        private DBDershaneTakipDataSetOgrenci dBDershaneTakipDataSetOgrenci;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private DBDershaneTakipDataSetOgrenciTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBoxGuncelle;
        private System.Windows.Forms.PictureBox pictureBoxKaydet;
        private System.Windows.Forms.PictureBox pictureBoxSil;
    }
}