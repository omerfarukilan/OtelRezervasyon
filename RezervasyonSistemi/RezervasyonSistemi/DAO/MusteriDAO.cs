using RezervasyonSistemi.DOMAİN;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using MySql.Data.MySqlClient;
using RezervasyonSistemi.DAO;
using System.Data;

namespace RezervasyonSistemi.DAO
{
    public class MusteriDAO
    {
        private readonly dbBaglanti dbBaglanti;

        public MusteriDAO()
        {
            this.dbBaglanti = new dbBaglanti();
        }

        public List<Musteri> TumMusterileriGetir()
        {
            List<Musteri> musteriler = new List<Musteri>();
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open(); 
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Musteri", conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        musteriler.Add(new Musteri(
                            Convert.ToInt32(reader["MusteriID"]),
                            reader["Isim"].ToString(),
                            reader["Soyisim"].ToString(),
                            reader["Telefon"].ToString(),
                            reader["Eposta"].ToString()
                        ));
                    }
                }
            }
            return musteriler;
        }

        public void MusteriEkle(Musteri musteri)
        {
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open(); 
                }

                using (MySqlCommand cmd = new MySqlCommand(@"
                INSERT INTO Musteri (Isim, Soyisim, Telefon, Eposta) 
                VALUES (@isim, @soyisim, @telefon, @eposta)", conn))
                {
                    cmd.Parameters.AddWithValue("@isim", musteri.Isim);
                    cmd.Parameters.AddWithValue("@soyisim", musteri.Soyisim);
                    cmd.Parameters.AddWithValue("@telefon", musteri.Telefon);
                    cmd.Parameters.AddWithValue("@eposta", musteri.Eposta);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MusteriSil(int musteriID)
        {
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open(); 
                }

                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Musteri WHERE MusteriID = @musteriID", conn))
                {
                    cmd.Parameters.AddWithValue("@musteriID", musteriID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool MusteriSilinebilirMi(int musteriID)
        {
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open(); 
                }

                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM Rezervasyon WHERE MusteriID = @musteriID", conn))
                {
                    cmd.Parameters.AddWithValue("@musteriID", musteriID);
                    int iliskiliKayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                    return iliskiliKayitSayisi == 0;
                }
            }
        }
    }
}
