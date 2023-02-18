using CustomerService1.Entities;
using CustomerService1.Models;

namespace CustomerService1.Data
{
    public interface IKontaktOsobaRepository
    {
        //get all kontakt osoba
        List<KontaktOsoba> getAllKontaktOsobe();
        //get kontakt osoba by id
        KontaktOsoba getKontaktOsobaById(Guid id);
        //create kontakt osoba
        KontaktOsobaConfirmation postKontaktOsoba(KontaktOsoba kontaktOsoba);
        //update kontakt osoba
        KontaktOsobaConfirmation updateKontaktOsoba(KontaktOsoba kontaktOsoba);
        //delete kontakt osoba
        void deleteKontaktOsoba(Guid id);
        //sacuvaj promene
        bool SaveChanges();
    }
}

