using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneTakip
{
    public partial class OgretmenEkrani : Form
    {
        public OgretmenEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciBilgiSistemi aa=new OgrenciBilgiSistemi();
            aa.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DenemeListe bb = new DenemeListe();
            bb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Odevler cc=new Odevler();
            cc.Show();
        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
