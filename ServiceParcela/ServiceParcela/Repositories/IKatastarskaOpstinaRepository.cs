using ServiceParcela.DtoModels;
using ServiceParcela.Entities;

namespace ServiceParcela.Repositories
{
    public interface IKatastarskaOpstinaRepository
    {
        //funkcija get all katastarska opstina
        List<Entities.KatastarskaOpstina> getAllKatastarskaOpstina();

        //get katastarska opstina by id
        Entities.KatastarskaOpstina getKatastarskaOpstinaByID(Guid id);

        //create katastarska opstina
        KatastarskaOpstinaDto postKatastarskaOpstina(Entities.KatastarskaOpstina katastarskaOpstina);

        //update katastarska opstina
        KatastarskaOpstinaDto putKatastarskaOpstina(Entities.KatastarskaOpstina katastarskaOpstina);

        //delete katastarska opstina
        void deleteKatastarskaOpstina(Guid id);

        //save katastarska opstina
        bool saveChanges();
    }
}
