using CustomerService1.Entities;

namespace CustomerService1.Data
{
    public interface IKupacRepository
    {
        //get all kupac
        List<Kupac> getAllKupci();
        //get kupac by id
        Kupac getKupacById(Guid id);
        //create kupac
        KupacConfirmation postKupac(Kupac kupac);
        //update kupac
        KupacConfirmation updateKupac(Kupac kupac);
        //delete kupac
        void deleteKupac(Guid id);
        //sacuvaj promene
        bool SaveChanges();
    }
}
