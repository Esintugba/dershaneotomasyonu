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
    public partial class Deneme : Form
    {
        public Deneme()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DenemeListe DD = new DenemeListe();
            DD.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Denemeler aa = new Denemeler();
            aa.Show();
            this.Hide();
        }
    }
}
