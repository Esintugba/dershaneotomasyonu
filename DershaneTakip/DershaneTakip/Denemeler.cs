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
using System.Security.Cryptography;

namespace DershaneTakip
{
    public partial class Denemeler : Form
    {
        public Denemeler()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void pictureBoxKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Denemeler (Ogrenci,BiyolojiNet,FizikNet,KimyaNet,CografyaNet,TurkceNet,TarihNet,MatematikNet,FelsefeNet,EdebiyatNet,GeometriNet,DenemeNo,DenemePuan) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@a1", textBoxOgrenci.Text);
            komutkaydet.Parameters.AddWithValue("@a2",textBoxBiyoloji.Text);
            komutkaydet.Parameters.AddWithValue("@a3",textBoxFizik.Text);
            komutkaydet.Parameters.AddWithValue("@a4",textBoxKimya.Text);
            komutkaydet.Parameters.AddWithValue("@a5",textBoxCografya.Text);
            komutkaydet.Parameters.AddWithValue("@a6",textBoxTurkce.Text);
            komutkaydet.Parameters.AddWithValue("@a7",textBoxTarih.Text);
            komutkaydet.Parameters.AddWithValue("@a8",textBoxMatematik.Text);
            komutkaydet.Parameters.AddWithValue("@a9",textBoxFelsefe .Text);
            komutkaydet.Parameters.AddWithValue("@a10",textBoxEdebiyat.Text);
            komutkaydet.Parameters.AddWithValue("@a11",textBoxGeometri.Text);
            komutkaydet.Parameters.AddWithValue("@a12",textBoxDenemeNo.Text);
            komutkaydet.Parameters.AddWithValue("@a13",textBoxPuan.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Kaydedildi");
        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxOgrenci.Clear();
            textBoxPuan.Clear();
            textBoxDenemeNo.Clear();
            textBoxBiyoloji.Clear();
            textBoxCografya.Clear();
            textBoxEdebiyat.Clear();
            textBoxFelsefe.Clear();
            textBoxFizik.Clear();
            textBoxGeometri.Clear();
            textBoxKimya.Clear();
            textBoxTarih.Clear();
            
        }

        private void Denemeler_Load(object sender, EventArgs e)
        {

        }
    }
}
