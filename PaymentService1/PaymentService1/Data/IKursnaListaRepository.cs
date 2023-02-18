using PaymentService1.Entities;

namespace PaymentService1.Data
{
    public interface IKursnaListaRepository
    {
        //get all kurs
        List<KursnaLista> getAllKurs();
        //get kurs by id
        KursnaLista getKursById(Guid id);
        //create kurs
        KursnaListaConfirmation postKurs(KursnaLista kurs);
        //update kurs
        KursnaListaConfirmation updateKurs(KursnaLista kurs);
        //delete kurs
        void deleteKurs(Guid id);
        //sacuvaj promene
        bool SaveChanges();
    }
}
