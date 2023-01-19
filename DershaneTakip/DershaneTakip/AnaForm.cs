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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OgrenciGirisEkranı aa = new OgrenciGirisEkranı();
            aa.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OgrenciGirisEkranı aa = new OgrenciGirisEkranı();
            aa.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OgretmenGirisEkrani bb = new OgretmenGirisEkrani();
            bb.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OgretmenGirisEkrani bb = new OgretmenGirisEkrani();
            bb.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            VeliGirisEkranı cc = new VeliGirisEkranı();
            cc.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            İdareGirisEkrani dd = new İdareGirisEkrani();
            dd.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            İdareGirisEkrani dd = new İdareGirisEkrani();
            dd.Show();
        }
    }
}
