using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DershaneTakip
{
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id,tc,ad,soyad, dogumtarihi, dogumyeri, mail, bolum, veli, telefon, sifre;

      

        private void OgrenciKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBDershaneTakipDataSetOgrenci.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.dBDershaneTakipDataSetOgrenci.Ogrenci);

            textBoxID.Text = id;
            maskedTextTc.Text = tc;
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            dateTimePicker1.Text = dogumtarihi;
            textBoxDogumYeri.Text = dogumyeri;
            textBoxMail.Text = mail;
            comboBoxBolum.Text = bolum;
            textBoxVeli.Text = veli;
            maskedTextTelefon.Text = telefon;
            textBoxSifre.Text = sifre;


        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            
                SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ID = @d1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@d1", textBoxID.Text);
                komutsil.ExecuteNonQuery();
                this.ogrenciTableAdapter.Fill(this.dBDershaneTakipDataSetOgrenci.Ogrenci);
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi");
              
           
        }

        private void pictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("update Ogrenci set TC=@a2,Ad=@a3,Soyad=@a4,DogumTarihi=@a5,DogumYeri=@a6,Mail=@a7,Bölüm=@a8,Veli=@a9,TelefonNo=@a10,Sifre=@a11 where ID=@a1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@a1", textBoxID.Text);
                komutguncelle.Parameters.AddWithValue("@a2", maskedTextTc.Text);
                komutguncelle.Parameters.AddWithValue("@a3", textBoxAd.Text);
                komutguncelle.Parameters.AddWithValue("@a4", textBoxSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a5", dateTimePicker1.Text);
                komutguncelle.Parameters.AddWithValue("@a6", textBoxDogumYeri.Text);
                komutguncelle.Parameters.AddWithValue("@a7", textBoxMail.Text);
                komutguncelle.Parameters.AddWithValue("@a8", comboBoxBolum.Text);
                komutguncelle.Parameters.AddWithValue("@a9", textBoxVeli.Text);
                komutguncelle.Parameters.AddWithValue("@a10", maskedTextTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@a11", textBoxSifre.Text);
                komutguncelle.ExecuteNonQuery();
                this.ogrenciTableAdapter.Fill(this.dBDershaneTakipDataSetOgrenci.Ogrenci);
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
        }

        private void pictureBoxKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(TC,Ad,Soyad,DogumTarihi,DogumYeri,Mail,Bölüm,Veli,TelefonNo,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", maskedTextTc.Text);
                komutkaydet.Parameters.AddWithValue("@p2", textBoxAd.Text);
                komutkaydet.Parameters.AddWithValue("@p3", textBoxSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
                komutkaydet.Parameters.AddWithValue("@p5", textBoxDogumYeri.Text);
                komutkaydet.Parameters.AddWithValue("@p6", textBoxMail.Text);
                komutkaydet.Parameters.AddWithValue("@p7", comboBoxBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p8", textBoxVeli.Text);
                komutkaydet.Parameters.AddWithValue("@p9", maskedTextTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p10", textBoxSifre.Text);
                komutkaydet.ExecuteNonQuery();
                this.ogrenciTableAdapter.Fill(this.dBDershaneTakipDataSetOgrenci.Ogrenci);
                bgl.baglanti().Close();
                MessageBox.Show("Öğrenci Başarıyla Kaydedildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, tc, ad, soyad, dogumtarihi, dogumyeri, mail, bolum, veli, telefon, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dogumtarihi = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dogumyeri = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            bolum = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            veli = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[10].Value.ToString();

            textBoxID.Text = id;
            maskedTextTc.Text = tc;
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            dateTimePicker1.Text = dogumtarihi;
            textBoxDogumYeri.Text = dogumyeri;
            textBoxMail.Text = mail;
            comboBoxBolum.Text = bolum;
            textBoxVeli.Text = veli;
            maskedTextTelefon.Text = telefon;
            textBoxSifre.Text = sifre;
            
        }
    }
}
