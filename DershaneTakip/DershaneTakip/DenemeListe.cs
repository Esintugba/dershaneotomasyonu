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
    public partial class DenemeListe : Form
    {
        public DenemeListe()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();
        private void DenemeListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBDershaneTakipDataSet3.Denemeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.denemelerTableAdapter.Fill(this.dBDershaneTakipDataSet3.Denemeler);


            //Grafiklere veritabanından veri çekme

            SqlCommand komut3 = new SqlCommand("select Ogrenci,sum(DenemePuan) From Denemeler group by Ogrenci", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Puan"].Points.AddXY(oku3[0], oku3[1]);
            }

            bgl.baglanti().Close();
        }


       

        
    }
}
