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

namespace RezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = idTxt.Text;
            string sifre = sifreTxt.Text;

            YoneticiDAO yoneticiDAO = new YoneticiDAO();
            bool girisBasarili = yoneticiDAO.YoneticiGirisKontrol(kullaniciAdi, sifre);

            if (girisBasarili)
            {
                YoneticiEkran yoneticiFormu = new YoneticiEkran();
                yoneticiFormu.Show();               
                this.Hide();  
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
