using RezervasyonSistemi.DOMAİN;
using System.Collections.Generic;
using RezervasyonSistemi.DAO;

namespace RezervasyonSistemi
{
    public class OdaService
    {
        private readonly OdaDAO odaDAO;

        public OdaService()
        {
            odaDAO = new OdaDAO();
        }

        public List<Oda> BosOdalariGetir()
        {
            return odaDAO.BosOdalariGetir();
        }

        public void OdaDurumuGuncelle(int odaID, string yeniDurum)
        {
            odaDAO.OdaDurumuGuncelle(odaID, yeniDurum);
        }

        public void OdaEkle(Oda oda)
        {
            odaDAO.OdaEkle(oda);
        }

        public void OdaSil(int odaID)
        {
            odaDAO.OdaSil(odaID);
        }
        public List<Oda> SadeceBosOdalariGetir()
        {
            return odaDAO.SadeceBosOdalariGetir();
        }
    }
}