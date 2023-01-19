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
    public partial class GirisCıkıs : Form
    {
        public GirisCıkıs()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, giris, cikis, tarih, ogrenci;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GirisCıkıs_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBDershaneTakipDataSet2.GirisCikis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            textBoxID.Text = id;
            textBoxGiris.Text = giris;
            textBoxCikis.Text = cikis;
            dateTimePicker1.Text = tarih;
            textBoxOgrenci.Text = ogrenci;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id,giris,cikis,tarih,ogrenci;
            id = dataGridView1.Rows[0].Cells[secilen].Value.ToString();
            giris = dataGridView1.Rows[1].Cells[secilen].Value.ToString();
            cikis = dataGridView1.Rows[2].Cells[secilen].Value.ToString();
            tarih= dataGridView1.Rows[3].Cells[secilen].Value.ToString();
            ogrenci= dataGridView1.Rows[4].Cells[secilen].Value.ToString();

            textBoxID.Text = id;
            textBoxGiris.Text = giris;
            textBoxCikis.Text = cikis;
            dateTimePicker1.Text = tarih;
            textBoxOgrenci.Text = ogrenci;
        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxCikis.Clear();
            textBoxGiris.Clear();
            
        }

        private void pictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update GirisCikis set GirisSaat=@e1,CıkısSaat=@e2,Tarih=@e3,Ogrenci=@e4 where ID=@e5", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@e5", textBoxID.Text);
            komutguncelle.Parameters.AddWithValue("@e1", textBoxGiris.Text);
            komutguncelle.Parameters.AddWithValue("@e2", textBoxCikis.Text);
            komutguncelle.Parameters.AddWithValue("@e3", dateTimePicker1.Text);
            komutguncelle.Parameters.AddWithValue("@e4", textBoxOgrenci.Text);
            komutguncelle.ExecuteNonQuery();
            
            bgl.baglanti().Close();
            this.girisCikisTableAdapter.Fill(this.dBDershaneTakipDataSet2.GirisCikis);


            MessageBox.Show("Başarıyla güncellendi.");

        }

        private void pictureBoxKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into GirisCikis (GirisSaat,CıkısSaat,Tarih,Ogrenci ) values (@d1,@d2,@d3,@d4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@d1", textBoxGiris.Text);
            komutkaydet.Parameters.AddWithValue("@d2", textBoxCikis.Text);
            komutkaydet.Parameters.AddWithValue("@d3", dateTimePicker1.Text);
            komutkaydet.Parameters.AddWithValue("@d4", textBoxOgrenci.Text);
            komutkaydet.ExecuteNonQuery();
            this.girisCikisTableAdapter.Fill(this.dBDershaneTakipDataSet2.GirisCikis);
            bgl.baglanti().Close();
            MessageBox.Show("Kaydetme başarılı.");

        }
    }
}
