using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi.DOMAİN
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Isim{ get; set; }
        public string Soyisim { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        

        public string TamAd => $"{Isim} {Soyisim}";

        public Musteri() { }

        public Musteri(int musteriID,string isim,string soyisim,string telefon,string eposta) 
        {
            MusteriID = musteriID;
            Isim = isim;
            Soyisim = soyisim;
            Telefon = telefon;
            Eposta = eposta;
           
        }
    }
}

