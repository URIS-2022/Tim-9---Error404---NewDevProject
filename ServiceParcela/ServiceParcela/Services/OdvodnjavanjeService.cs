using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;
using System.Xml.Linq;

namespace ServiceParcela.Services
{
    public class OdvodnjavanjeService  : IOdvodnjavanjeRepository
    {
        public static List<Odvodnjavanje> odvodnjavanjes { get; set; } = new List<Odvodnjavanje>();
        private readonly IMapper mapper;
        private readonly ParcelaContex context;

        public OdvodnjavanjeService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            //  FillData();
        }
        /*
        private void FillData()
        {
            odvodnjavanjes.AddRange(new List<Odvodnjavanje>
            {
                new Odvodnjavanje
                {
                    odvodnjavanjeID = Guid.Parse("bfd7815f-b9d8-4032-bfcf-9c400c49bc99"),
                    nazivOdvodnjavanja = "Odvodnjavano"
                },
                new Odvodnjavanje
                {
                    odvodnjavanjeID = Guid.Parse("389eab9c-5869-4745-a838-0b9211c227a3"),
                    nazivOdvodnjavanja = "Ostalo"
                }
            });
        }
        */

        public void deleteOdvodnjavanje(Guid id)
        {
            Entities.Odvodnjavanje odvodnjavanje = getOdvodnjavanjeByID(id);
            context.odvodnjavanja.Remove(odvodnjavanje);
        }

        public List<Odvodnjavanje> getAllOdvodnjavanje()
        {
            return context.odvodnjavanja.ToList();
        }

        public Odvodnjavanje getOdvodnjavanjeByID(Guid id)
        {
            return context.odvodnjavanja.FirstOrDefault(odvodnjavanje => odvodnjavanje.odvodnjavanjeID == id);

        }

        public OdvodnjavanjeDto postOdvodnjavanje(Odvodnjavanje odvodnjavanje)
        {
            odvodnjavanje.odvodnjavanjeID = Guid.NewGuid();
            var novoOD = context.odvodnjavanja.Add(odvodnjavanje);
            return mapper.Map<OdvodnjavanjeDto>(odvodnjavanje);
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public OdvodnjavanjeDto putOdvodnjavanje(Odvodnjavanje odvodnjavanje)
        {
            throw new NotImplementedException();
        }
    }
}
