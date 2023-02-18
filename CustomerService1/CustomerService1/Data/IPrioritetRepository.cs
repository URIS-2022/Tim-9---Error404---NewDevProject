using CustomerService1.Entities;
using CustomerService1.Models;

namespace CustomerService1.Data
{
    public interface IPrioritetRepository
    {
        //get all prioritet
        List<Prioritet> getAllPrioritet();
        //get prioritet by id
        Prioritet getPrioritetById(Guid id);
        //create prioritet
        PrioritetConfirmation postPrioritet(Prioritet prioritet);
        //update prioritet
        PrioritetConfirmation updatePrioritet(Prioritet prioritet);
        //delete prioritet
        void deletePrioritet(Guid id);
        //sacuvaj promene
        bool SaveChanges();
    }
}
