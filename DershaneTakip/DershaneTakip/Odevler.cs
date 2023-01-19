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
    public partial class Odevler : Form
    {
        public Odevler()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            textBoxOdevNo.Clear();
            richTextTurkce.Clear();
            richTextMatematik.Clear();
            richTextGeometri.Clear();
            richTextEdebiyat.Clear();
            richTextCografya.Clear();
            richTextFelsefe.Clear();
            richTextTarih.Clear();
            richTextKimya.Clear();
            richTextFizik.Clear();
            richTextBiyoloji.Clear();

        }

        private void pictureBoxKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Odevler (OdevNo,BiyolojiOdev,KimyaOdev,FizikOdev,FelsefeOdev,TurkceOdev,CografyaOdev,MatematikOdev,TarihOdev,OdevTarihi,EdebiyatOdev,GeometriOdev) values (@e1,@e2,@e3,@e4,@e5,@e6,@e7,@e8,@e9,@e10,@e11,@e12)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@e1", textBoxOdevNo.Text);
            komutkaydet.Parameters.AddWithValue("@e2", richTextBiyoloji.Text);
            komutkaydet.Parameters.AddWithValue("@e3", richTextKimya.Text);
            komutkaydet.Parameters.AddWithValue("@e4", richTextFizik.Text);
            komutkaydet.Parameters.AddWithValue("@e5", richTextFelsefe.Text);
            komutkaydet.Parameters.AddWithValue("@e6", richTextTurkce.Text);
            komutkaydet.Parameters.AddWithValue("@e7", richTextCografya.Text);
            komutkaydet.Parameters.AddWithValue("@e8",richTextMatematik.Text);
            komutkaydet.Parameters.AddWithValue("@e9",richTextTarih.Text);
            komutkaydet.Parameters.AddWithValue("@e10", dateTimePicker1.Text);
            komutkaydet.Parameters.AddWithValue("@e11", richTextEdebiyat.Text);
            komutkaydet.Parameters.AddWithValue("@e12",richTextGeometri.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ödev başarıyla kaydedildi.");
        }

        private void Odevler_Load(object sender, EventArgs e)
        {

        }
    }
}
