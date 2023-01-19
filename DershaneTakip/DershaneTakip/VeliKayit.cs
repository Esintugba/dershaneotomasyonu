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
using System.Security.Policy;

namespace DershaneTakip
{
    public partial class VeliKayit : Form
    {
        public VeliKayit()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, tc, ad, soyad, dogumtarihi, dogumyeri, mail, telefon, sifre, ogrenci, meslek;

        private void VeliKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBDershaneTakipDataSet.Veli' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.veliTableAdapter.Fill(this.dBDershaneTakipDataSet.Veli);

            textBoxID.Text = id;
            maskedTextTc.Text = tc;
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            dateTimePicker1.Text = dogumtarihi;
            textBoxDogumYeri.Text = dogumyeri;
            textBoxMail.Text = mail;
            maskedTextTelefon.Text = telefon;
            textBoxSifre.Text = sifre;
            textBoxOgrenci.Text = ogrenci;
            textBoxMeslek.Text = meslek;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id,tc, ad, soyad, dogumtarihi, dogumyeri, mail, telefon, sifre, ogrenci, meslek;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dogumtarihi = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dogumyeri = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mail = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            telefon= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            sifre= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            ogrenci= dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            meslek= dataGridView1.Rows[secilen].Cells[10].Value.ToString();


            textBoxID.Text = id;
            maskedTextTc.Text = tc;
            textBoxAd.Text= ad;
            textBoxSoyad.Text = soyad;
            dateTimePicker1.Text = dogumtarihi;
            textBoxDogumYeri.Text = dogumyeri;
            textBoxMail.Text = mail;
            maskedTextTelefon.Text = telefon;
            textBoxSifre.Text = sifre;
            textBoxOgrenci.Text = ogrenci;
            textBoxMeslek.Text = meslek;




        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete From Veli where ID=@e1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@e1", textBoxID.Text);
                komutsil.ExecuteNonQuery();
                this.veliTableAdapter.Fill(this.dBDershaneTakipDataSet.Veli);
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi başarıyla gerçekleştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar Deneyiniz.");

            }
        }

        private void pictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("Update Veli set TC=@t2,Ad=@t3,Soyad=@t4,DogumTarihi=@t5,DogumYeri=@t6,Mail=@t7,TelefonNo=@t8,Sifre=@t9,Ogrenci=@t10,Mesleği=@t11 where ID=@t1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@t1", textBoxID.Text);
                komutguncelle.Parameters.AddWithValue("@t2", maskedTextTc.Text);
                komutguncelle.Parameters.AddWithValue("@t3", textBoxAd.Text);
                komutguncelle.Parameters.AddWithValue("@t4", textBoxSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@t5", dateTimePicker1.Text);
                komutguncelle.Parameters.AddWithValue("@t6", textBoxDogumYeri.Text);
                komutguncelle.Parameters.AddWithValue("@t7", textBoxMail.Text);
                komutguncelle.Parameters.AddWithValue("@t8", maskedTextTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@t9", textBoxSifre.Text);
                komutguncelle.Parameters.AddWithValue("@t10", textBoxOgrenci.Text);
                komutguncelle.Parameters.AddWithValue("@t11", textBoxSifre.Text);
                komutguncelle.ExecuteNonQuery();
                this.veliTableAdapter.Fill(this.dBDershaneTakipDataSet.Veli);
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirildi.");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar Deneyiniz.");
            }

        }

        private void pictureBoxKaydet_Click(object sender, EventArgs e)
        {
            try
            {


                SqlCommand komutkaydet = new SqlCommand("Insert into Veli (TC,Ad,Soyad,DogumTarihi,DogumYeri,Mail,TelefonNo,Sifre,Ogrenci,Mesleği) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@d1", maskedTextTc.Text);
                komutkaydet.Parameters.AddWithValue("@d2", textBoxAd.Text);
                komutkaydet.Parameters.AddWithValue("@d3", textBoxSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@d4", dateTimePicker1.Text);
                komutkaydet.Parameters.AddWithValue("@d5", textBoxDogumYeri.Text);
                komutkaydet.Parameters.AddWithValue("@d6", textBoxMail.Text);
                komutkaydet.Parameters.AddWithValue("@d7", maskedTextTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@d8", textBoxSifre.Text);
                komutkaydet.Parameters.AddWithValue("@d9", textBoxOgrenci.Text);
                komutkaydet.Parameters.AddWithValue("@d10", textBoxMeslek.Text);
                komutkaydet.ExecuteNonQuery();
                this.veliTableAdapter.Fill(this.dBDershaneTakipDataSet.Veli);
                bgl.baglanti().Close();
                MessageBox.Show("Veli Başarıyla Kaydedildi.");
            }
            catch(Exception)
            {
                 
                MessageBox.Show("HATA! Tekrar Deneyiniz.");
                maskedTextTc.Clear();
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxDogumYeri.Clear();
                textBoxMail.Clear();
                maskedTextTelefon.Clear();
                textBoxSifre.Clear();
                textBoxOgrenci.Clear();
                textBoxMeslek.Clear();

            }
        }
            
           
        }
    }

