using ServiceParcela.DtoModels;

namespace ServiceParcela.Repositories
{
    public interface IParcelaRepository
    {
        //funkcija get all parcela
        List<Entities.Parcela> getAllParcela();

        //get parcela by id
        Entities.Parcela getParcelaByID(Guid id);

        //create parcela
        ParcelaDto postParcela(Entities.Parcela parcela);

        //update parcela
        ParcelaDto putParcela(Entities.Parcela parcela);

        //delete parcela
        void deleteParcela(Guid id);

        //save parcela
        bool saveChanges();
        
    }
}
