using PaymentService1.Entities;

namespace PaymentService1.Data
{
    public interface IUplataRepository
    {
        //get all uplata
        List<Uplata> getAllUplate();
        //get uplata by id
        Uplata getUplataById(Guid id);
        //create uplata
        UplataConfirmation postUplata(Uplata uplata);
        //update uplata
        UplataConfirmation updateUplata(Uplata uplata);
        //delete uplata
        void deleteUplata(Guid id);
        //sacuvaj promene
        bool SaveChanges();
    }
}
