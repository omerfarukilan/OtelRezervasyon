using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi.DOMAİN
{
    public class Oda
    {
        public int OdaID { get; set; }
        public int KatOdaNo { get; set; }
        public string OdaTur { get; set; }
        public decimal Fiyat { get; set; }
        public string Durum { get; set; }

        public string OdaBilgisi => $"Oda {KatOdaNo} - {OdaTur} ({Fiyat:C})";
        public Oda() { }

        public Oda(int odaID, int katOdaNo, string odaTur, decimal fiyat, string durum)
        {
            OdaID = odaID;
            KatOdaNo = katOdaNo;
            OdaTur = odaTur;
            Fiyat = fiyat;
            Durum = durum;
        }
    }
}


