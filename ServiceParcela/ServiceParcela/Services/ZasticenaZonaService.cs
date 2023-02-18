using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;
using System.Xml.Linq;

namespace ServiceParcela.Services
{
    public class ZasticenaZonaService : IZasticenaZonaRepository
    {
        public static List<ZasticenaZona> zasticenaZonas { get; set; } = new List<ZasticenaZona>();
        private readonly IMapper mapper;
        private readonly ParcelaContex context;

        public ZasticenaZonaService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            // FillData();
        }
        /*
        private void FillData()
        {
            zasticenaZonas.AddRange(new List<ZasticenaZona>
            {
                new ZasticenaZona
                {
                    zasticenaZonaID = Guid.Parse("0ff62375-b94c-4415-9ae0-096bb738b8bc"),
                    nazivZasticeneZone = "1"
                },
                new ZasticenaZona
                {
                    zasticenaZonaID = Guid.Parse("ef917114-63cd-43c0-a760-e5657f7581c6"),
                    nazivZasticeneZone = "2"
                },
                new ZasticenaZona
                {
                    zasticenaZonaID = Guid.Parse("7f2f2e22-6324-4c77-a05e-de203e9d4045"),
                    nazivZasticeneZone = "3"
                },
                new ZasticenaZona
                {
                    zasticenaZonaID = Guid.Parse("9aa1cd9b-6e6c-4a9e-8840-641070ab5246"),
                    nazivZasticeneZone = "4"
                }
            });
        }
        */

        public void deleteZasticenaZona(Guid id)
        {
            Entities.ZasticenaZona zasticenaZona = getZasticenaZonaByID(id);
            context.zasticeneZone.Remove(zasticenaZona);
        }

        public List<ZasticenaZona> getAllZasticenaZona()
        {
            return context.zasticeneZone.ToList();
        }

        public ZasticenaZona getZasticenaZonaByID(Guid id)
        {
            return context.zasticeneZone.FirstOrDefault(zasticenaZona => zasticenaZona.zasticenaZonaID == id);

        }

        public ZasticenaZonaDto postZasticenaZona(ZasticenaZona zasticenaZona)
        {
            zasticenaZona.zasticenaZonaID = Guid.NewGuid();
            var novaZZ = context.zasticeneZone.Add(zasticenaZona);
            return mapper.Map<ZasticenaZonaDto>(zasticenaZona);
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public ZasticenaZonaDto putZasticenaZona(ZasticenaZona zasticenaZona)
        {
            throw new NotImplementedException();
        }
    }
}
