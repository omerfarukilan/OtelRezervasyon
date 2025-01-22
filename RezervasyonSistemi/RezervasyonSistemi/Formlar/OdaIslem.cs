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
    public partial class OdaIslem : Form
    {
        private readonly OdaService odaService;

        public OdaIslem()
        {
            InitializeComponent();
            odaService = new OdaService();
            DataGridViewiAyarla();
            DataGridViewiGuncelle();
        }

        private void DataGridViewiAyarla()
        {
            odaDGV.AutoGenerateColumns = false;
            odaDGV.Columns.Clear();

            odaDGV.Columns.AddRange(
                new DataGridViewTextBoxColumn
                {
                    Name = "OdaID",
                    DataPropertyName = "OdaID",
                    HeaderText = "Oda ID",
                    Width = 80,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "KatOdaNo",
                    DataPropertyName = "KatOdaNo",
                    HeaderText = "Kat/Oda No",
                    Width = 100,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "OdaTur",
                    DataPropertyName = "OdaTur",
                    HeaderText = "Oda Türü",
                    Width = 100,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleLeft }
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Fiyat",
                    DataPropertyName = "Fiyat",
                    HeaderText = "Fiyat",
                    Width = 100,
                    DefaultCellStyle = {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "C2" 
                    }
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Durum",
                    DataPropertyName = "Durum",
                    HeaderText = "Durum",
                    Width = 100,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                }
            );

            foreach (DataGridViewColumn column in odaDGV.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void DataGridViewiGuncelle()
        {
            odaDGV.DataSource = null;
            odaDGV.DataSource = odaService.BosOdalariGetir();
        }

        private void ekleTxt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(odaNoTxt.Text) ||
                    string.IsNullOrWhiteSpace(odaTurTxt.Text) ||
                    string.IsNullOrWhiteSpace(odaFiyatTxt.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var oda = new Oda(
                    0, 
                    Convert.ToInt32(odaNoTxt.Text),
                    odaTurTxt.Text,
                    Convert.ToDecimal(odaFiyatTxt.Text),
                    "Boş" 
                );

                odaService.OdaEkle(oda);
                MessageBox.Show("Oda başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                odaNoTxt.Clear();
                odaTurTxt.Clear();
                odaFiyatTxt.Clear();
                DataGridViewiGuncelle();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli değerler giriniz.\nKat/Oda No: Sayı\nFiyat: Sayı",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda eklenirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (odaDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçili odayı silmek istediğinizden emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int odaID = Convert.ToInt32(odaDGV.SelectedRows[0].Cells["OdaID"].Value);
                        odaService.OdaSil(odaID);

                        MessageBox.Show("Oda başarıyla silindi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DataGridViewiGuncelle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek odayı seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void geriBtn_Click(object sender, EventArgs e)
        {
            RezervasyonIslem rezervasyonIslem = new RezervasyonIslem();
            rezervasyonIslem.Show();
            this.Hide();
        }

        private void ileriBtn_Click(object sender, EventArgs e)
        {
            MusteriIslem musteriIslem = new MusteriIslem();
            musteriIslem.Show();
            this.Hide();
        }

        private void odaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
