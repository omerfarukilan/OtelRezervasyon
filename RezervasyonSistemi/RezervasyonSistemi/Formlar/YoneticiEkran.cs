using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RezervasyonSistemi.DAO;
using RezervasyonSistemi.DOMAİN;

namespace RezervasyonSistemi
{
    public partial class YoneticiEkran : Form
    {
        public YoneticiEkran()
        {
            InitializeComponent();
        }

        private void YoneticiEkran_Load(object sender, EventArgs e)
        {

        }

        private void rzvIslBtn_Click(object sender, EventArgs e)
        {
            RezervasyonIslem rezervasyon = new RezervasyonIslem();
            rezervasyon.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdaIslem oda = new OdaIslem();
            oda.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriIslem musteri = new MusteriIslem();
            musteri.Show();
            this.Hide();
        }
    }
}
