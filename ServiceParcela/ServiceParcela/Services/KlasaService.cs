using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;
using System.Xml.Linq;

namespace ServiceParcela.Services
{
    public class KlasaService  : IKlasaRepository
    {
        public static List<Klasa> klasas { get; set; } = new List<Klasa>();
        private readonly IMapper mapper;
        private readonly ParcelaContex context;


        public KlasaService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            // FillData();
        }
        /*
        private void FillData()
        {
            klasas.AddRange(new List<Klasa>
            {
                new Klasa
                {
                    klasaID = Guid.Parse("ea46fc42-300c-42bd-85ec-b41864c5bfc8"),
                    nazivKlase = "I"
                },
                new Klasa
                {
                    klasaID = Guid.Parse("8b479542-bc13-4b6e-8139-f2dc2c47ae74"),
                    nazivKlase = "II"
                },
                new Klasa
                {
                    klasaID = Guid.Parse("14791175-a1d8-4ce1-81ce-ab25bc9af38e"),
                    nazivKlase = "III"
                },
                new Klasa
                {
                    klasaID = Guid.Parse("17a15c54-c4d3-40a1-b531-2b142aadb2c8"),
                    nazivKlase = "IV"
                },
                new Klasa
                {
                    klasaID = Guid.Parse("8adefb3d-8818-4c27-b6c2-276b4063d619"),
                    nazivKlase = "V"
                },
                new Klasa
                {
                    klasaID = Guid.Parse("8ed8e0eb-fae8-4de9-9916-1e7f84625d2c"),
                    nazivKlase = "VI"
                },
                new Klasa
                {
                    klasaID = Guid.Parse("459a1c86-2562-4599-a1ce-d5259c4a30db"),
                    nazivKlase = "VII"
                },
                new Klasa
                {
                    klasaID = Guid.Parse("50bfacfe-4048-4bfe-ab1f-5beaeb33e01c"),
                    nazivKlase = "VIII"
                }
            });
        }
        */

        public void deleteKlasa(Guid id)
        {
            Entities.Klasa klasa = getKlasaByID(id);
            context.klase.Remove(klasa);
        }

        public List<Klasa> getAllKlasa()
        {
            return context.klase.ToList();
        }

        public Klasa getKlasaByID(Guid id)
        {
            return context.klase.FirstOrDefault(klasa => klasa.klasaID == id);

        }

        public KlasaDto postKlasa(Klasa klasa)
        {
            klasa.klasaID = Guid.NewGuid();
            var novaKL = context.klase.Add(klasa);
            return mapper.Map<KlasaDto>(klasa);

            //throw new NotImplementedException();
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public KlasaDto putKlasa(Klasa klasa)
        {
            throw new NotImplementedException();
        }
    }
}
