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
    public partial class OgrenciGirisEkranı : Form
    {
        public OgrenciGirisEkranı()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select*From Ogrenci where TC=@p1 and Sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextTc.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSifre.Text);
            SqlDataReader oku=komut.ExecuteReader();
            if(oku.Read())
            {
                OgrenciBilgiSistemi bg=new OgrenciBilgiSistemi();
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

        private void OgrenciGirisEkranı_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
