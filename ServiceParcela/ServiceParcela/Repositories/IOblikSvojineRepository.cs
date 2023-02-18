using ServiceParcela.DtoModels;

namespace ServiceParcela.Repositories
{
    public interface IOblikSvojineRepository
    {
        //funkcija get all oblik svojine
        List<Entities.OblikSvojine> getAllOblikSvojine();

        //get oblik svojine by id
        Entities.OblikSvojine getOblikSvojineByID(Guid id);

        //create oblik svojine
        OblikSvojineDto postOblikSvojine(Entities.OblikSvojine oblikSvojine);

        //update oblik svojine
        OblikSvojineDto putOblikSvojine(Entities.OblikSvojine oblikSvojine);

        //delete oblik svojine
        void deleteOblikSvojine(Guid id);

        //save oblik svojine
        bool saveChanges();
    }
}
