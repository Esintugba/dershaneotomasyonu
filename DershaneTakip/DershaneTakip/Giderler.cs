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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string id, maas, su, elektrik, dogalgaz, internet, telefon, diger;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, maas, su, elektrik, dogalgaz, internet, telefon, diger;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            maas = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            elektrik = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dogalgaz = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            internet = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

            textBoxID.Text = id;
            textBoxMaas.Text = maas;
            textBoxSu.Text = su;
            textBoxElektrik.Text = elektrik;
            textBoxDogalgaz.Text = dogalgaz;
            textBoxInternet.Text = internet;
            textBoxTelefon.Text = telefon;
            textBoxDiger.Text = diger;


        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBDershaneTakipDataSet1.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.dBDershaneTakipDataSet1.Giderler);

            textBoxID.Text = id;
            textBoxMaas.Text = maas;
            textBoxSu.Text = su;
            textBoxElektrik.Text= elektrik;
            textBoxDogalgaz.Text = dogalgaz;
            textBoxInternet.Text = internet;
            textBoxTelefon.Text = telefon;
            textBoxDiger.Text = diger;

            SqlCommand komut3 = new SqlCommand("select ID,sum(Maaş) From Giderler group by ID", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }

            bgl.baglanti().Close();


        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void pictureBoxGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutguncelle = new SqlCommand("update Giderler set Maaş=@e1,Su=@e2,Elektrik=@e3,Dogalgaz=@e4,Internet=@e5,Telefon=@e6,Diger=@e7 where Id=@e8", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@e8", textBoxID.Text);
                komutguncelle.Parameters.AddWithValue("@e1", textBoxMaas.Text);
                komutguncelle.Parameters.AddWithValue("@e2", textBoxSu.Text);
                komutguncelle.Parameters.AddWithValue("@e3", textBoxElektrik.Text);
                komutguncelle.Parameters.AddWithValue("@e4", textBoxDogalgaz.Text);
                komutguncelle.Parameters.AddWithValue("@e5", textBoxInternet.Text);
                komutguncelle.Parameters.AddWithValue("@e6", textBoxTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@e7", textBoxDiger.Text);
                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.giderlerTableAdapter.Fill(this.dBDershaneTakipDataSet1.Giderler);
                MessageBox.Show("Güncelleme işlemi başarılıyla tamamlandı.");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Tekrar Deneyiniz.");
            }
        }
            

        private void pictureBoxKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Giderler (Maaş,Su,Elektrik,Dogalgaz,Internet,Telefon,Diger) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@d1", textBoxMaas.Text);
                komutkaydet.Parameters.AddWithValue("@d2", textBoxSu.Text);
                komutkaydet.Parameters.AddWithValue("@d3", textBoxElektrik.Text);
                komutkaydet.Parameters.AddWithValue("@d4", textBoxDogalgaz.Text);
                komutkaydet.Parameters.AddWithValue("@d5", textBoxInternet.Text);
                komutkaydet.Parameters.AddWithValue("@d6", textBoxTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@d7", textBoxDiger.Text);
                komutkaydet.ExecuteNonQuery();
                this.giderlerTableAdapter.Fill(this.dBDershaneTakipDataSet1.Giderler);
                bgl.baglanti().Close();
                MessageBox.Show("Giderler Başarıyla Kaydedildi");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Tekrar Deneyiniz.");
            }
            
        }
    }
}
