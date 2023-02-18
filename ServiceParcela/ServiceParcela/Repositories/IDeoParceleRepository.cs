using ServiceParcela.DtoModels;
using ServiceParcela.Entities;

namespace ServiceParcela.Repositories
{
    public interface IDeoParceleRepository
    {
        //funkcija get all deo parcele
        List<Entities.DeoParcele> getAllDeoParcele();

        //get deo parcele by id
        Entities.DeoParcele getDeoParceleByID(Guid id);

        //create deo parcele
        DeoParceleDto postDeoParcele(Entities.DeoParcele deoParcele);

        //update deo parcele
        DeoParceleDto putDeoParcele(Entities.DeoParcele deoParcele);

        //delete deo parcele
        void deleteDeoParcele(Guid id);

        //save deo parcele
        bool saveChanges();
        
    }
}
