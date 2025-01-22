using RezervasyonSistemi.DOMAİN;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using RezervasyonSistemi.DAO;
using MySql.Data.MySqlClient;



namespace RezervasyonSistemi.Service
{
    public class RezervasyonService
    {
        private readonly IRezervasyonDAO rezervasyonDAO;

        public RezervasyonService()
        {
            this.rezervasyonDAO = new RezervasyonDAO();
        }

        public void RezervasyonEkle(Rezervasyon rezervasyon)
        {
            rezervasyonDAO.RezervasyonEkle(rezervasyon);
        }

        public List<Rezervasyon> TumRezervasyonlariGetir()
        {
            return rezervasyonDAO.TumRezervasyonlariGetir();
        }
        public List<Rezervasyon> RezervasyonlariGetir()
        {
            return rezervasyonDAO.TumRezervasyonlariGetir();
        }
        public void RezervasyonSilVeOdaGuncelle(int rezervasyonID)
        {
            rezervasyonDAO.RezervasyonSilVeOdaGuncelle(rezervasyonID);
        }
        public void RezervasyonSil(int rezervasyonID)
        {
            rezervasyonDAO.RezervasyonSil(rezervasyonID);
        }

        public List<Oda> BosOdalariGetir()
        {
            return rezervasyonDAO.BosOdalariGetir();
        }

        public List<Musteri> TumMusterileriGetir()
        {
            return rezervasyonDAO.TumMusterileriGetir();
        }

        public void OdaDurumuGuncelle(int odaID, string yeniDurum)
        {
            rezervasyonDAO.OdaDurumuGuncelle(odaID, yeniDurum);
        }


        public decimal ToplamFiyatHesapla(DateTime giris, DateTime cikis, decimal odaFiyat)
        {
            int gunSayisi = (int)(cikis - giris).TotalDays;
            if (gunSayisi < 1) gunSayisi = 1;
            return gunSayisi * odaFiyat;
        }
    }
}