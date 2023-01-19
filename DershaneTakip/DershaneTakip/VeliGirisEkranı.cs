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
    public partial class VeliGirisEkranı : Form
    {
        public VeliGirisEkranı()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select*From Ogrenci where TC=@a1", bgl.baglanti());
            komut.Parameters.AddWithValue("@a1", maskedTextTc.Text);

            SqlCommand komut2=new SqlCommand("Select*From Veli where TC=@b1 and Sifre=@b2",bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1", maskedTextVeliTc.Text);
            komut2.Parameters.AddWithValue("@b2", textBoxSifre.Text);

            SqlDataReader oku=komut.ExecuteReader();
            SqlDataReader oku1 = komut2.ExecuteReader();
            if(oku1.Read())
            {
                OgrenciBilgiSistemi bg = new OgrenciBilgiSistemi();
                bg.Show();
            }
           

            else if (oku.Read())
            {
                OgrenciBilgiSistemi bg = new OgrenciBilgiSistemi();
                bg.Show();
            }
            
            else
            {
                MessageBox.Show("Hata! Tekrar Deneyiniz");
                maskedTextTc.Clear();
                maskedTextVeliTc.Clear();   
                textBoxSifre.Clear();
            }
            bgl.baglanti().Close();

        }

        private void VeliGirisEkranı_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
