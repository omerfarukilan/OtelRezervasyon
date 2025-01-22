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
using RezervasyonSistemi.Service;
using RezervasyonSistemi.DAO;

namespace RezervasyonSistemi
{
    public partial class RezervasyonIslem : Form
    {
        private RezervasyonService rezervasyonService;
        private decimal gunlukFiyat;

        public RezervasyonIslem()
        {
            InitializeComponent();
            rezervasyonService = new RezervasyonService(); 
            ComboBoxlariDoldur();
        }

        private void DataGridViewiGuncelle()
        {
            var rezervasyonlar = rezervasyonService.RezervasyonlariGetir();
            // Debug için kontrol
            foreach (var rezervasyon in rezervasyonlar)
            {
                Console.WriteLine($"RezervasyonID: {rezervasyon.RezervasyonID}");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rezervasyonlar;
        }

        private void ComboBoxlariDoldur()
        {
            try
            {
                var musteriler = rezervasyonService.TumMusterileriGetir();
                musteriCmb.DataSource = musteriler;
                musteriCmb.DisplayMember = "TamAd";
                musteriCmb.ValueMember = "MusteriID";

                var odalar = rezervasyonService.BosOdalariGetir();
                odaCmb.DataSource = odalar;
                odaCmb.DisplayMember = "OdaBilgisi";
                odaCmb.ValueMember = "OdaID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri yüklerken hata oluştu: " + ex.Message);
            }
        }

        private void DataGridViewiAyarla()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.AddRange(
                new DataGridViewTextBoxColumn
                {
                    Name = "RezervasyonID",
                    DataPropertyName = "RezervasyonID",
                    HeaderText = "Rezervasyon No",
                    Width = 80
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "KatOdaNo",
                    DataPropertyName = "KatOdaNo",
                    HeaderText = "Oda No",
                    Width = 70
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "MusteriAdiSoyadi",
                    DataPropertyName = "MusteriAdiSoyadi",
                    HeaderText = "Müşteri Adı Soyadı",
                    Width = 150
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "GirisTarihi",
                    DataPropertyName = "GirisTarihi",
                    HeaderText = "Giriş Tarihi",
                    Width = 100,
                    DefaultCellStyle = { Format = "dd.MM.yyyy" }
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "CikisTarihi",
                    DataPropertyName = "CikisTarihi",
                    HeaderText = "Çıkış Tarihi",
                    Width = 100,
                    DefaultCellStyle = { Format = "dd.MM.yyyy" }
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "ToplamFiyat",
                    DataPropertyName = "ToplamFiyat",
                    HeaderText = "Toplam Fiyat",
                    Width = 100,
                    DefaultCellStyle = { Format = "C2", Alignment = DataGridViewContentAlignment.MiddleRight }
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "OdaTur",
                    DataPropertyName = "OdaTur",
                    HeaderText = "Oda Türü",
                    Width = 100
                }
            );
        }

        private void OdaSecildi(object sender, EventArgs e)
        {
            if (odaCmb.SelectedItem != null)
            {
                var secilenOda = (Oda)odaCmb.SelectedItem;
                gunlukFiyat = secilenOda.Fiyat;
                TarihDegisti(null, null); 
            }
        }

        private void TarihDegisti(object sender, EventArgs e)
        {
            if (gunlukFiyat > 0)
            {
                int gunSayisi = (cikisPicker.Value - girisPicker.Value).Days;
                if (gunSayisi > 0)
                {
                    decimal toplamFiyat = gunlukFiyat * gunSayisi;
                    toplamFiyatLbl.Text = $"Toplam Fiyat: {toplamFiyat:C2}";
                }
            }
        }

        private void RezervasyonIs_Load(object sender, EventArgs e)
        {
            ComboBoxlariDoldur();
            DataGridViewiAyarla();
            DataGridViewiGuncelle();

            girisPicker.MinDate = DateTime.Today;
            cikisPicker.MinDate = DateTime.Today.AddDays(1);

            girisPicker.ValueChanged += TarihDegisti;
            cikisPicker.ValueChanged += TarihDegisti;
            odaCmb.SelectedIndexChanged += OdaSecildi;
        }

        private void rzvBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (odaCmb.SelectedItem == null || musteriCmb.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen müşteri ve oda seçimini yapınız.");
                    return;
                }

                var secilenOda = (Oda)odaCmb.SelectedItem;

                var rezervasyon = new Rezervasyon
                {
                    MusteriID = (int)musteriCmb.SelectedValue,
                    OdaID = secilenOda.OdaID,
                    GirisTarihi = girisPicker.Value,
                    CikisTarihi = cikisPicker.Value,
                    ToplamFiyat = rezervasyonService.ToplamFiyatHesapla(
                        girisPicker.Value,
                        cikisPicker.Value,
                        secilenOda.Fiyat
                    )
                };

                rezervasyonService.RezervasyonEkle(rezervasyon);
                MessageBox.Show("Rezervasyon başarıyla yapıldı.");

                DataGridViewiGuncelle();
                ComboBoxlariDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçili rezervasyonu silmek istediğinizden emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var row = dataGridView1.SelectedRows[0];
                        int rezervasyonID = Convert.ToInt32(row.Cells[0].Value);

                        rezervasyonService.RezervasyonSilVeOdaGuncelle(rezervasyonID);
                        DataGridViewiGuncelle();
                        ComboBoxlariDoldur();

                        MessageBox.Show("Rezervasyon başarıyla silindi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Rezervasyon silinirken hata oluştu: " + ex.Message,
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek rezervasyonu seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            MusteriIslem musteriIslem = new MusteriIslem();
            musteriIslem.Show();
            this.Hide();
        }

        private void ileriBtn_Click(object sender, EventArgs e)
        {
            OdaIslem odaIslem = new OdaIslem();
            odaIslem.Show();
            this.Hide();
        }

        private void toplamFiyatLbl_Click(object sender, EventArgs e)
        {

        }
    }
}