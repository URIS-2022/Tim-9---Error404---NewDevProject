using ServiceParcela.DtoModels;
using ServiceParcela.Entities;

namespace ServiceParcela.Repositories
{
    public interface IObradivostRepository
    {
        //funkcija get all obradivost
        List<Entities.Obradivost> getAllObradivost();

        //get obradivost by id
        Entities.Obradivost getObradivostByID(Guid id);

        //create obradivost
        ObradivostDto postObradivost(Entities.Obradivost obradivost);

        //update obradivost
        ObradivostDto putObradivost(Entities.Obradivost obradivost);

        //delete obradivost
        void deleteObradivost(Guid id);

        //save obradivost
        bool saveChanges();
    }
}
