using System;
using AuctionService.DtoModels;
using AuctionService.Entities;
using AuctionService.Repository;
using AutoMapper;

namespace AuctionService.Services
{
    public class LicitacijaService : ILicitacijaRepository
    {
        private readonly JavnoNadmetanjeContext context;
        private readonly IMapper mapper;
        public static List<Licitacija> licitacijas { get; set; } = new List<Licitacija>();

        public LicitacijaService(IMapper mapper, JavnoNadmetanjeContext context)
        {
            this.context = context;
            this.mapper = mapper;
            FillData();
        }


        private void FillData()
        {
            licitacijas.AddRange(new List<Licitacija>
            {
                new Licitacija
                {
                    licitacijaID = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939"),
                    broj = 1,
                    godina = 2022,
                    datum = DateTime.Parse("2022-2-17"),
                    ogranicenja = 1,
                    korakCene = 100,
                    listaDokumentacijeFizickaLica = new List<string>(){ "dok1_fl", "dok2_fl"},
                    listaDokumentacijePravnaLica = new List<string>(){ "dok1_pl", "dok1_pl"},
                    javnoNadmetanjeId = Guid.Parse("208a48a5-371c-4f9d-ac23-18bb176ff8f3"),
                    rokZaDostavljanje = DateTime.Parse("2022-2-15")
                },
                new Licitacija
                {
                    licitacijaID = Guid.Parse("1de13266-85e8-4120-8b1f-daacc32c5811"),
                    broj = 2,
                    godina = 2022,
                    datum = DateTime.Parse("2022-2-18"),
                    ogranicenja = 1,
                    korakCene = 200,
                    listaDokumentacijeFizickaLica = new List<string>(){ "dok1_fl", "dok2_fl"},
                    listaDokumentacijePravnaLica = new List<string>(){ "dok1_pl", "dok1_pl"},
                    javnoNadmetanjeId = Guid.Parse("208a48a5-371c-4f9d-ac23-18bb176ff8f3"),
                    rokZaDostavljanje = DateTime.Parse("2022-2-16")
                }
            });
        }
        public void deleteLicitacija(Guid id)
        {
            Entities.Licitacija licitacija = getLicitacijaById(id);
            // context.licitacije.Add(licitacija);
            licitacijas.Remove(licitacija);

        }

        public List<Licitacija> getAllLicitacija()
        {
            return context.licitacije.ToList();
           // return (from l in licitacijas select l).ToList();
        }

        public Licitacija getLicitacijaById(Guid id)
        {
            return context.licitacije.FirstOrDefault(licitacija => licitacija.licitacijaID == id);
            //return licitacijas.FirstOrDefault(l => l.licitacijaID == id);
        }

        public LicitacijaConformationDto postLicitacija(Licitacija licitacija)
        {
            licitacija.licitacijaID = Guid.NewGuid();
            //var novaLicitacija = context.licitacije.Add(licitacija);
            //return mapper.Map<LicitacijaConformationDto>(novaLicitacija.Entity);
            licitacijas.Add(licitacija);
            return mapper.Map<LicitacijaConformationDto>(licitacija);
        }

        public bool saveChanges()
        {
            //return context.SaveChanges() > 1;
            return true;
        }

        public LicitacijaConformationDto updateLicitacija(Licitacija licitacija)
        {
            throw new NotImplementedException();
        }
    }
}

