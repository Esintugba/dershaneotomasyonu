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
    public partial class İdareEkrani : Form
    {
        public İdareEkrani()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciKayit aa=new OgrenciKayit();
            aa.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgretmenKayit bb = new OgretmenKayit();
            bb.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeliKayit cc=new VeliKayit();
            cc.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelKayit dd=new PersonelKayit();
            dd.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deneme ee = new Deneme();
            ee.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Odevler ff=new Odevler();
            ff.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Giderler gg = new Giderler();
            gg.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ödemeler hh = new Ödemeler();
            hh.Show();
            
        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
