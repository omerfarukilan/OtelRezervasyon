using RezervasyonSistemi.DOMAİN;
using System.Collections.Generic;
using RezervasyonSistemi.DAO;

namespace RezervasyonSistemi
{

    public class MusteriService
    {
        private readonly MusteriDAO musteriDAO;

        public MusteriService()
        {
            musteriDAO = new MusteriDAO();
        }

        public List<Musteri> TumMusterileriGetir()
        {
            return musteriDAO.TumMusterileriGetir();
        }

        public void MusteriEkle(Musteri musteri)
        {
            musteriDAO.MusteriEkle(musteri);
        }

        public void MusteriSil(int musteriID)
        {
            musteriDAO.MusteriSil(musteriID);
        }
        public bool MusteriSilinebilirMi(int musteriID) 
        {
            return musteriDAO.MusteriSilinebilirMi(musteriID);
        }
    }
}