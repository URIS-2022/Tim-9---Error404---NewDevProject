using System;
using AuctionService.DtoModels;
using AuctionService.Entities;
using AuctionService.Repository;
using AutoMapper;
namespace AuctionService.Services
{
    public class JavnoNadmetanjeService : IJavnoNadmetanjeRepository
    {
        public static List<Entities.JavnoNadmetanje> javnoNadmetanjes { get; set; } = new List<Entities.JavnoNadmetanje>();
        private readonly JavnoNadmetanjeContext javnoNadmetanjeContext;
        private readonly IMapper mapper;

        public JavnoNadmetanjeService(IMapper mapper, JavnoNadmetanjeContext context)
        {
            this.javnoNadmetanjeContext = context;
            this.mapper = mapper;
            FillData();
        }

        private void FillData()
        {
            javnoNadmetanjes.AddRange(new List<Entities.JavnoNadmetanje>
            {
                new Entities.JavnoNadmetanje
                {
                    javnoNadmetanjeID = Guid.Parse("208a48a5-371c-4f9d-ac23-18bb176ff8f3"),
                    datum = DateTime.Parse("2022-2-17"),
                    vremePocetka = DateTime.Parse("2022-2-17T08:00:00"),//godina, mesec, dan, sat, minut, sekunda
                    vremeKraja = DateTime.Parse("2022-2-17T10:00:00"),
                    pocetnaCenaPoHektaru = 5000,
                    izuzeto = false,
                    tipID = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
                    izlicitiranaCena = 7500,
                    periodZakupa = 12,
                    brojUcesnika = 10,
                    visinaDopuneDepozita = 500,
                    krug = 1,
                    statusNadmetanjaID = Guid.Parse("8aaa90c8-56f3-4a76-b07a-f895eded5a84")
                },
                new Entities.JavnoNadmetanje
                {
                    javnoNadmetanjeID = Guid.Parse("13d6ced2-ab84-4132-bf67-e96037f4813d"),
                    datum = DateTime.Parse("2022-2-18"),
                    vremePocetka = DateTime.Parse("2022-2-18T08:00:00"),
                    vremeKraja = DateTime.Parse("2022-2-18T10:00:00"),
                    pocetnaCenaPoHektaru = 4000,
                    izuzeto = false,
                    tipID = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
                    izlicitiranaCena = 6000,
                    periodZakupa = 12,
                    brojUcesnika = 10,
                    visinaDopuneDepozita = 400,
                    krug = 1,
                    statusNadmetanjaID = Guid.Parse("8aaa90c8-56f3-4a76-b07a-f895eded5a84")
                }
            }) ;
        }

        public void deleteJavnoNadmetanje(Guid id)
        {
            Entities.JavnoNadmetanje jn = getJavnoNadmetanjeByID(id);
            javnoNadmetanjeContext.javnaNadmetanja.Remove(jn);
            //javnoNadmetanjes.Remove(jn);
        }

        public List<Entities.JavnoNadmetanje> getJavnaNadmetanja()
        {
            //return javnoNadmetanjeContext.javnaNadmetanja.ToList();
            return (from jn in javnoNadmetanjes select jn).ToList();
        }

        public Entities.JavnoNadmetanje getJavnoNadmetanjeByID(Guid id)
        {
            //return javnoNadmetanjeContext.javnaNadmetanja.FirstOrDefault(jn => jn.javnoNadmetanjeID == id);
            return javnoNadmetanjes.FirstOrDefault(jn => jn.javnoNadmetanjeID == id);
        }

        public JavnoNadmetanjeConformationDto postJavnoNadmetanje(Entities.JavnoNadmetanje jn)
        {
            jn.javnoNadmetanjeID = Guid.NewGuid();
            //var novoJN = javnoNadmetanjeContext.Add(jn);
            //return mapper.Map<JavnoNadmetanjeConformationDto>(novoJN.Entity);
            javnoNadmetanjes.Add(jn);
            return mapper.Map<JavnoNadmetanjeConformationDto>(jn);
        }

        public bool saveChanges()
        {
            return true;
        }

        public JavnoNadmetanjeConformationDto updateJavnoNadmetanje(Entities.JavnoNadmetanje jn)
        {
            throw new NotImplementedException();
        }
    }
}

