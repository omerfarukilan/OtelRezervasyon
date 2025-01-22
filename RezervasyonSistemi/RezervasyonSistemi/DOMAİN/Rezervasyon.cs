using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RezervasyonSistemi.DOMAİN
{
    public class Rezervasyon
    {
        public int RezervasyonID { get; set; }
        public int MusteriID { get; set; }
        public int OdaID { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal ToplamFiyat { get; set; }
        public string MusteriAdiSoyadi { get; set; }
        public int KatOdaNo { get; set; }
        public string OdaTur { get; set; }

        public Rezervasyon() { }

        public Rezervasyon(int rezervasyonID, int musteriID, int odaId, DateTime girisTarihi, DateTime cikisTarihi, decimal toplamFiyat)
        {
            RezervasyonID = rezervasyonID;
            MusteriID = musteriID;
            OdaID = odaId;
            GirisTarihi = girisTarihi;
            CikisTarihi = cikisTarihi;
            ToplamFiyat = toplamFiyat;
        }
    }
}



