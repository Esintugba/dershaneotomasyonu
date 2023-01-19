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
    public partial class OgrenciBilgiSistemi : Form
    {
        public OgrenciBilgiSistemi()
        {
            InitializeComponent();
        }

        private void OgrenciBilgiSistemi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBDershaneTakipDataSet6.GirisCikis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisCikisTableAdapter.Fill(this.dBDershaneTakipDataSet6.GirisCikis);
            // TODO: Bu kod satırı 'dBDershaneTakipDataSet6.GirisCikis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisCikisTableAdapter.Fill(this.dBDershaneTakipDataSet6.GirisCikis);
            // TODO: Bu kod satırı 'dBDershaneTakipDataSet5.Odevler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odevlerTableAdapter.Fill(this.dBDershaneTakipDataSet5.Odevler);
            // TODO: Bu kod satırı 'dBDershaneTakipDataSet4.Denemeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.denemelerTableAdapter.Fill(this.dBDershaneTakipDataSet4.Denemeler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ödemeler dd = new Ödemeler();
            dd.Show();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DenemeListe AA = new DenemeListe();
            AA.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
