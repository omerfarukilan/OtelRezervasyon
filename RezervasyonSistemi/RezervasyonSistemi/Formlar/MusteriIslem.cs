using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RezervasyonSistemi.DOMAİN;

namespace RezervasyonSistemi.DAO
{
    public partial class MusteriIslem : Form
    {
        private readonly MusteriService musteriService;

        public MusteriIslem()
        {
            InitializeComponent();
            musteriService = new MusteriService();
            DataGridViewiDoldur();
        }

        private void DataGridViewiDoldur()
        {
            musteriDGV.DataSource = musteriService.TumMusterileriGetir();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri yeniMusteri = new Musteri(
                    0, 
                    isimTxt.Text,
                    soyisimTxt.Text,
                    telefonTxt.Text,
                    epostaTxt.Text
                );

                if (string.IsNullOrWhiteSpace(isimTxt.Text) ||
                    string.IsNullOrWhiteSpace(soyisimTxt.Text))
                {
                    MessageBox.Show("İsim ve Soyisim alanları zorunludur.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                musteriService.MusteriEkle(yeniMusteri);

                MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataGridViewiDoldur();

                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri eklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silTxt_Click(object sender, EventArgs e)
        {
            try
            {
                if (musteriDGV.SelectedRows.Count > 0)
                {
                    int musteriID = Convert.ToInt32(musteriDGV.SelectedRows[0].Cells["MusteriID"].Value);

                    if (musteriService.MusteriSilinebilirMi(musteriID))
                    {
                        DialogResult sonuc = MessageBox.Show(
                            "Müşteriyi silmek istediğinizden emin misiniz?",
                            "Onay",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (sonuc == DialogResult.Yes)
                        {
                            musteriService.MusteriSil(musteriID);
                            MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi");
                            DataGridViewiDoldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Bu müşterinin aktif rezervasyonları bulunduğu için silinemez.",
                            "Uyarı",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata");
            }
        }
            
        

        private void Temizle()
        {
            isimTxt.Clear();
            soyisimTxt.Clear();
            telefonTxt.Clear();
            epostaTxt.Clear();
        }

        private void MusteriIslem_Load(object sender, EventArgs e)
        {
            musteriDGV.AutoGenerateColumns = false;

            musteriDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MusteriID",
                HeaderText = "Müşteri ID",
                Name = "MusteriID"
            });
            musteriDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Isim",
                HeaderText = "İsim"
            });
            musteriDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Soyisim",
                HeaderText = "Soyisim"
            });
            musteriDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefon",
                HeaderText = "Telefon"
            });
            musteriDGV.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Eposta",
                HeaderText = "E-Posta"
            });
        }

        private void MusteriIslem_Load_1(object sender, EventArgs e)
        {

        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
           OdaIslem odaIslem = new OdaIslem();
            odaIslem.Show();
            this.Hide();
        }

        private void ileriBtn_Click(object sender, EventArgs e)
        {
            RezervasyonIslem rezervasyonIslem = new RezervasyonIslem();
            rezervasyonIslem.Show();
            this.Hide();
        }
    }
}
