using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RezervasyonSistemi.DAO
{
    class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330060; User=25_132330060; Password=!nif.ogr60IL");

            try
            {
                baglanti.Open();
                Console.WriteLine("Bağlantı başarıyla açıldı.");
                return baglanti;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı hatası: " + ex.Message);
                return null;
            }
        }
    }

}