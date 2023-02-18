using ServiceParcela.DtoModels;
using ServiceParcela.Entities;

namespace ServiceParcela.Repositories
{
    public interface IKulturaRepository
    {
        //funkcija get all kultura
        List<Entities.Kultura> getAllKultura();

        //get kultura by id
        Entities.Kultura getKulturaByID(Guid id);

        //create kultura
        KulturaDto postKultura(Entities.Kultura kultura);

        //update kultura
        KulturaDto putKultura(Entities.Kultura kultura);

        //delete kultura
        void deleteKultura(Guid id);

        //save kultura
        bool saveChanges();
    }
}
