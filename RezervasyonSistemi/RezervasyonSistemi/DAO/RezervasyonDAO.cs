using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using RezervasyonSistemi.DOMAİN;

namespace RezervasyonSistemi.DAO
{
    public interface IRezervasyonDAO
    {
        void RezervasyonEkle(Rezervasyon rezervasyon);
        List<Rezervasyon> TumRezervasyonlariGetir();
        void RezervasyonSil(int rezervasyonID);
        List<Oda> BosOdalariGetir(); 
        void OdaDurumuGuncelle(int odaID, string yeniDurum); 
        List<Musteri> TumMusterileriGetir();
        void RezervasyonSilVeOdaGuncelle(int rezervasyonID);
    }

    public class RezervasyonDAO : IRezervasyonDAO
    {
        private readonly dbBaglanti dbBaglanti;

        public RezervasyonDAO()
        {
            this.dbBaglanti = new dbBaglanti();
        }

        public void RezervasyonEkle(Rezervasyon rezervasyon)
        {
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn != null)
                {
                    try
                    {
                        using (var transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                using (MySqlCommand cmd = new MySqlCommand(@"
                            INSERT INTO Rezervasyon (MusteriID, OdaID, GirisTarihi, CikisTarihi, ToplamFiyat)
                            VALUES (@musteriID, @odaID, @girisTarihi, @cikisTarihi, @toplamFiyat)", conn))
                                {
                                    cmd.Transaction = transaction;
                                    cmd.Parameters.AddWithValue("@musteriID", rezervasyon.MusteriID);
                                    cmd.Parameters.AddWithValue("@odaID", rezervasyon.OdaID);
                                    cmd.Parameters.AddWithValue("@girisTarihi", rezervasyon.GirisTarihi);
                                    cmd.Parameters.AddWithValue("@cikisTarihi", rezervasyon.CikisTarihi);
                                    cmd.Parameters.AddWithValue("@toplamFiyat", rezervasyon.ToplamFiyat);
                                    cmd.ExecuteNonQuery();
                                }

                                using (MySqlCommand updateCmd = new MySqlCommand(@"
                            UPDATE Oda SET Durum = 'Dolu' 
                            WHERE OdaID = @odaID", conn))
                                {
                                    updateCmd.Transaction = transaction;
                                    updateCmd.Parameters.AddWithValue("@odaID", rezervasyon.OdaID);
                                    updateCmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                            }
                            catch
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public List<Rezervasyon> TumRezervasyonlariGetir()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand(@"
                        SELECT r.*, CONCAT(m.Isim, ' ', m.Soyisim) as MusteriAdiSoyadi, 
                               o.KatOdaNo, o.OdaTur
                        FROM Rezervasyon r
                        INNER JOIN Musteri m ON r.MusteriID = m.MusteriID
                        INNER JOIN Oda o ON r.OdaID = o.OdaID", conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rezervasyon = new Rezervasyon
                            {
                                RezervasyonID = Convert.ToInt32(reader["RezervasyonID"]),
                                MusteriID = Convert.ToInt32(reader["MusteriID"]),
                                OdaID = Convert.ToInt32(reader["OdaID"]),
                                GirisTarihi = Convert.ToDateTime(reader["GirisTarihi"]),
                                CikisTarihi = Convert.ToDateTime(reader["CikisTarihi"]),
                                ToplamFiyat = Convert.ToDecimal(reader["ToplamFiyat"]),
                                MusteriAdiSoyadi = reader["MusteriAdiSoyadi"].ToString(),
                                KatOdaNo = Convert.ToInt32(reader["KatOdaNo"]),
                                OdaTur = reader["OdaTur"].ToString()
                            };

                            rezervasyonlar.Add(rezervasyon);
                        }
                    }
                }
            }
            return rezervasyonlar;
        }
        public List<Oda> BosOdalariGetir()
        {
            List<Oda> odalar = new List<Oda>();
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Oda WHERE Durum = 'Boş'", conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odalar.Add(new Oda(
                                Convert.ToInt32(reader["OdaID"]),
                                Convert.ToInt32(reader["KatOdaNo"]),
                                reader["OdaTur"].ToString(),
                                Convert.ToDecimal(reader["Fiyat"]),
                                reader["Durum"].ToString()
                            ));
                        }
                    }
                }
            }
            return odalar;
        }


        public void OdaDurumuGuncelle(int odaID, string yeniDurum)
        {
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE Oda SET Durum = @durum WHERE OdaID = @odaID", conn))
                    {
                        cmd.Parameters.AddWithValue("@durum", yeniDurum);
                        cmd.Parameters.AddWithValue("@odaID", odaID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
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

        public void RezervasyonSil(int rezervasyonID)
        {
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Rezervasyon WHERE RezervasyonID = @rezervasyonID", conn))
                    {
                        cmd.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public void RezervasyonSilVeOdaGuncelle(int rezervasyonID)
        {

            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                try
                {
                    int odaID;
                    using (MySqlCommand cmdGetOdaID = new MySqlCommand("SELECT OdaID FROM Rezervasyon WHERE RezervasyonID = @rezervasyonID", conn))
                    {
                        cmdGetOdaID.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);
                        object result = cmdGetOdaID.ExecuteScalar();

                        if (result == null)
                        {
                            throw new Exception($"Rezervasyon ID {rezervasyonID} bulunamadı.");
                        }

                        odaID = Convert.ToInt32(result);
                    }

                    using (MySqlCommand cmdDeleteRezervasyon = new MySqlCommand("DELETE FROM Rezervasyon WHERE RezervasyonID = @rezervasyonID", conn))
                    {
                        cmdDeleteRezervasyon.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);
                        cmdDeleteRezervasyon.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmdUpdateOda = new MySqlCommand("UPDATE Oda SET Durum = 'Boş' WHERE OdaID = @odaID", conn))
                    {
                        cmdUpdateOda.Parameters.AddWithValue("@odaID", odaID);
                        cmdUpdateOda.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyon silme işlemi sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}

