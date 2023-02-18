using ServiceParcela.DtoModels;
using ServiceParcela.Entities;

namespace ServiceParcela.Repositories
{
    public interface IKlasaRepository
    {
        //funkcija get all klasa
        List<Entities.Klasa> getAllKlasa();

        //get klasa by id
        Entities.Klasa getKlasaByID(Guid id);

        //create klasa
        KlasaDto postKlasa(Entities.Klasa klasa);

        //update klasa
        KlasaDto putKlasa(Entities.Klasa klasa);

        //delete klasa
        void deleteKlasa(Guid id);

        //save klasa
        bool saveChanges();
    }
}
