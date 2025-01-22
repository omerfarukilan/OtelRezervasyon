using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RezervasyonSistemi.DAO
{
    public class YoneticiDAO
    {
        public bool YoneticiGirisKontrol(string kullaniciAdi, string sifre)
        {
            try
            {
                dbBaglanti db = new dbBaglanti();
                MySqlConnection conn = db.baglantiGetir();  
               
                string query = "SELECT COUNT(*) FROM YoneticiGiris WHERE Yonetici = @Yonetici AND Sifre = @Sifre";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Yonetici", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

               
                int kullaniciSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                return kullaniciSayisi > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }
    }
}

