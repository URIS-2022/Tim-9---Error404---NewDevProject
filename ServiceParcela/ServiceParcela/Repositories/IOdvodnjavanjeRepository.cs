using ServiceParcela.DtoModels;
using ServiceParcela.Entities;

namespace ServiceParcela.Repositories
{
    public interface IOdvodnjavanjeRepository
    {
        //funkcija get all odvodnjavanje
        List<Entities.Odvodnjavanje> getAllOdvodnjavanje();

        //get odvodnjavanje by id
        Entities.Odvodnjavanje getOdvodnjavanjeByID(Guid id);

        //create odvodnjavanje
        OdvodnjavanjeDto postOdvodnjavanje(Entities.Odvodnjavanje odvodnjavanje);

        //update odvodnjavanje
        OdvodnjavanjeDto putOdvodnjavanje(Entities.Odvodnjavanje odvodnjavanje);

        //delete odvodnjavanje
        void deleteOdvodnjavanje(Guid id);

        //save odvodnjavanje
        bool saveChanges();
        
    }
}
