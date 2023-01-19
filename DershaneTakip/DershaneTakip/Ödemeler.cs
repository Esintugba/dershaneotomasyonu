using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DershaneTakip
{
    public partial class Ödemeler : Form
    {
        public Ödemeler()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void buttonOdeme_Click(object sender, EventArgs e)
        {
            //OgrenciId textbox'a çekme
            SqlCommand komutid = new SqlCommand("select ID from Ogrenci", bgl.baglanti());
            SqlDataReader okuid = komutid.ExecuteReader();
            while (okuid.Read())
            {
                textBoxOgrenciID.Text = okuid[0].ToString();
            }
            bgl.baglanti().Close();


            //ödenen tutardan kalan tutarı çıkarma
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(textBoxOdenenTutar.Text);
            kalan = Convert.ToInt16(textBoxÖdenecekTutar.Text);
            yeniborc = kalan - odenen;
            textBoxKalanBorc.Text = yeniborc.ToString();

            //Yeni tutarı veritabanına kaydetme
            SqlCommand komut = new SqlCommand("update Odemeler set TC=@p2,Ad=@p3,Soyad=@p4,Odenen=@p5,OdemeTarih=@p6,KalanBorc=@p7,Borc=@p8 where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxOgrenciID.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextOgrenciTC.Text);
            komut.Parameters.AddWithValue("@p3", textBoxOgrenciAd.Text);
            komut.Parameters.AddWithValue("@p4", textBoxOgrenciSoyad.Text);
            komut.Parameters.AddWithValue("@p5", textBoxOdenenTutar.Text);
            komut.Parameters.AddWithValue("@p6", dateTimePickerOdemeTarihi.Text);
            komut.Parameters.AddWithValue("@p7", textBoxKalanBorc.Text);
            komut.Parameters.AddWithValue("@p8", textBoxÖdenecekTutar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödemesi Alındı");

            

        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBoxGuncelle_Click(object sender, EventArgs e)
        {

            maskedTextOgrenciTC.Clear();
            textBoxOgrenciAd.Clear();
            textBoxOgrenciSoyad.Clear();
            textBoxÖdenecekTutar.Clear();
            textBoxOdenenTutar.Clear();
            textBoxKalanBorc.Clear();
           


                

        }
    }

       
    }

