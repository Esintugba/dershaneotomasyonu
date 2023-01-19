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
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, tc, ad, soyad, dogumtarihi, dogumyeri, mail, telefon, departman;

        private void PersonelKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBDershaneTakipDataSetPersonel.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.dBDershaneTakipDataSetPersonel.Personel);


            textBoxID.Text = id;
            maskedTextTc.Text = tc;
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            dateTimePicker1.Text = dogumtarihi;
            textBoxDogumYeri.Text = dogumyeri;
            textBoxMail.Text = mail;
            maskedTextTelefon.Text = telefon;
            textBoxDepartman.Text = departman;

        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from Personel where ID=@e1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@e1", textBoxID.Text);
                komutsil.ExecuteNonQuery();
                this.personelTableAdapter.Fill(this.dBDershaneTakipDataSetPersonel.Personel);
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen Tekrar Deneyiniz");
            }
           

        }

        private void pictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("Update Personel set TC=@t2,Ad=@t3,Soyad=@t4,DogumTarihi=@t5,DogumYeri=@t6,Mail=@t7,TelefonNo=@t8,Departman=@t9 where ID=@t1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@t1", textBoxID.Text);
                komutguncelle.Parameters.AddWithValue("@t2", maskedTextTc.Text);
                komutguncelle.Parameters.AddWithValue("@t3", textBoxAd.Text);
                komutguncelle.Parameters.AddWithValue("@t4", textBoxSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@t5", dateTimePicker1.Text);
                komutguncelle.Parameters.AddWithValue("@t6", textBoxDogumYeri.Text);
                komutguncelle.Parameters.AddWithValue("@t7", textBoxMail.Text);
                komutguncelle.Parameters.AddWithValue("@t8", maskedTextTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@t9", textBoxDepartman.Text);
                komutguncelle.ExecuteNonQuery();
                this.personelTableAdapter.Fill(this.dBDershaneTakipDataSetPersonel.Personel);
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar Deneyin.");
            }
        }

        private void pictureBoxKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Personel (TC,Ad,Soyad,DogumTarihi,DogumYeri,Mail,TelefonNo,Departman) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@d1", maskedTextTc.Text);
                komutkaydet.Parameters.AddWithValue("@d2", textBoxAd.Text);
                komutkaydet.Parameters.AddWithValue("@d3", textBoxSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@d4", dateTimePicker1.Text);
                komutkaydet.Parameters.AddWithValue("@d5", textBoxDogumYeri.Text);
                komutkaydet.Parameters.AddWithValue("@d6", textBoxMail.Text);
                komutkaydet.Parameters.AddWithValue("@d7", maskedTextTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@d8", textBoxDepartman.Text);
                komutkaydet.ExecuteNonQuery();
                this.personelTableAdapter.Fill(this.dBDershaneTakipDataSetPersonel.Personel);
                bgl.baglanti().Close();
                MessageBox.Show("Personel başarıyla kaydedildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Tekrar Deneyiniz");
                maskedTextTc.Clear();
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxDogumYeri.Clear();
                textBoxMail.Clear();
                maskedTextTelefon.Clear();
                textBoxDepartman.Clear();

            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, tc, ad, soyad, dogumtarihi, dogumyeri, mail, telefon, departman;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad=dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyad=dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dogumtarihi=dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dogumyeri=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mail=dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            telefon=dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            departman=dataGridView1.Rows[secilen].Cells[8].Value.ToString();


            textBoxID.Text = id;
            maskedTextTc.Text = tc;
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            dateTimePicker1.Text = dogumtarihi;
            textBoxDogumYeri.Text = dogumyeri;
            textBoxMail.Text = mail;
            maskedTextTelefon.Text = telefon;
            textBoxDepartman.Text = departman;
            
        }
    }
}
