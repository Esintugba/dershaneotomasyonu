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
    public partial class İdareGirisEkrani : Form
    {
        public İdareGirisEkrani()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select*From İdare where TC=@d1 and Sifre=@d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", maskedTextTc.Text);
            komut.Parameters.AddWithValue("@d2", textBoxSifre.Text);
            SqlDataReader oku=komut.ExecuteReader();
            if (oku.Read())
            {
                İdareEkrani bg = new İdareEkrani();
                bg.Show();
            }
            else
            {
                MessageBox.Show("Hata! Tekrar Deneyin");
                maskedTextTc.Clear();
                textBoxSifre.Clear();
            }
            bgl.baglanti().Close();   
        }

        private void İdareGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
