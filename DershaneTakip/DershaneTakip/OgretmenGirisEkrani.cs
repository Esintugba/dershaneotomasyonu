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
    public partial class OgretmenGirisEkrani : Form
    {
        public OgretmenGirisEkrani()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select*From Ogretmen where TC=@c1 and Sifre=@c2", bgl.baglanti());
            komut.Parameters.AddWithValue("@c1", maskedTextTc.Text);
            komut.Parameters.AddWithValue("@c2", textBoxSifre.Text);
            SqlDataReader oku=komut.ExecuteReader();
            if (oku.Read())
            {
                OgretmenEkrani bg = new OgretmenEkrani();
                bg.Show();
            }
            else
            {
                MessageBox.Show("Hata! Tekrar Deneyiniz");
                maskedTextTc.Clear();
                textBoxSifre.Clear();
            }
            bgl.baglanti().Close();
        }

        private void OgretmenGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
