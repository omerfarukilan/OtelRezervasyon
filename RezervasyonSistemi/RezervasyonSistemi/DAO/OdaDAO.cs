using RezervasyonSistemi.DOMAİN;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using MySql.Data.MySqlClient;
using RezervasyonSistemi.DAO;

namespace RezervasyonSistemi
{
    public class OdaDAO
    {
        private readonly dbBaglanti dbBaglanti;

        public OdaDAO()
        {
            this.dbBaglanti = new dbBaglanti();
        }
       
        public List<Oda> BosOdalariGetir()
        {
            List<Oda> odalar = new List<Oda>();
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Oda", conn))
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
        public List<Oda> SadeceBosOdalariGetir()
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
    

        public void OdaEkle(Oda oda)
        {
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn != null)
                {
                    using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO Oda (KatOdaNo, OdaTur, Fiyat, Durum) 
                    VALUES (@katOdaNo, @odaTur, @fiyat, @durum)", conn))
                    {
                        cmd.Parameters.AddWithValue("@katOdaNo", oda.KatOdaNo);
                        cmd.Parameters.AddWithValue("@odaTur", oda.OdaTur);
                        cmd.Parameters.AddWithValue("@fiyat", oda.Fiyat);
                        cmd.Parameters.AddWithValue("@durum", oda.Durum);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void OdaSil(int odaID)
        {
            using (MySqlConnection conn = dbBaglanti.baglantiGetir())
            {
                if (conn != null)
                {
                    try
                    {
                        using (MySqlCommand checkCmd = new MySqlCommand(@"
                    SELECT COUNT(*) FROM Rezervasyon 
                    WHERE OdaID = @odaID", conn))
                        {
                            checkCmd.Parameters.AddWithValue("@odaID", odaID);
                            int rezervasyonSayisi = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (rezervasyonSayisi > 0)
                            {
                                throw new Exception("Bu odaya ait aktif rezervasyon bulunmaktadır. Oda silinemez!");
                            }
                        }

                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Oda WHERE OdaID = @odaID", conn))
                        {
                            cmd.Parameters.AddWithValue("@odaID", odaID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}