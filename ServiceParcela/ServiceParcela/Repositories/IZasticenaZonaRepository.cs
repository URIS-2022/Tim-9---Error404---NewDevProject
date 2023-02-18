using ServiceParcela.DtoModels;
using ServiceParcela.Entities;

namespace ServiceParcela.Repositories
{
    public interface IZasticenaZonaRepository
    {
        //funkcija get all zasticena zona
        List<Entities.ZasticenaZona> getAllZasticenaZona();

        //get zasticena zona by id
        Entities.ZasticenaZona getZasticenaZonaByID(Guid id);

        //create zasticena zona
        ZasticenaZonaDto postZasticenaZona(Entities.ZasticenaZona zasticenaZona);

        //update zasticena zona
        ZasticenaZonaDto putZasticenaZona(Entities.ZasticenaZona zasticenaZona);

        //delete zasticena zona
        void deleteZasticenaZona(Guid id);

        //save zasticena zona
        bool saveChanges();
    }
}
