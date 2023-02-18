using AutoMapper;
using CustomerService1.Entities;
using CustomerService1.Models;

namespace CustomerService1.Data
{
    public class KontaktOsobaRepository : IKontaktOsobaRepository
    {
        public static List<KontaktOsoba> kontaktOsobas { get; set; } = new List<KontaktOsoba>();
        private readonly IMapper mapper;
        private readonly KupacContext context;


        public KontaktOsobaRepository(IMapper mapper, KupacContext context)
        {
           // FillData();
            this.mapper = mapper;
            this.context = context;
        }
        /*
        private void FillData()
        {
            kontaktOsobas.AddRange(new List<KontaktOsoba>
            {
                new KontaktOsoba
                {
                    KontaktOsobaID= Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939"),
                    Ime= "Sanja",
                    Prezime= "Nikolic",
                    Funkcija= "funkc1",
                    Telefon="0626684354"
                },
                new KontaktOsoba
                {
                    KontaktOsobaID= Guid.Parse("1de13266-85e8-4120-8b1f-daacc32c5811"),
                    Ime= "Nikola",
                    Prezime= "Petrovic",
                    Funkcija= "funkc2",
                    Telefon="0619964357"
                }
            });
        }*/
        public void deleteKontaktOsoba(Guid id)
        {
            Entities.KontaktOsoba kontakt = getKontaktOsobaById(id);
            context.kontaktOsoba.Remove(kontakt);
        }

        public List<KontaktOsoba> getAllKontaktOsobe()
        {
            return context.kontaktOsoba.ToList();
        }

        public KontaktOsoba getKontaktOsobaById(Guid id)
        {
            return context.kontaktOsoba.FirstOrDefault(ko => ko.KontaktOsobaID == id);
        }

        public KontaktOsobaConfirmation postKontaktOsoba(KontaktOsoba kontaktOsoba)
        {
            kontaktOsoba.KontaktOsobaID = Guid.NewGuid();
            var novaKO = context.kontaktOsoba.Add(kontaktOsoba);
            return mapper.Map<KontaktOsobaConfirmation>(kontaktOsoba);
            /*  kontaktOsoba.KontaktOsobaID = Guid.NewGuid();
              kontaktOsobas.Add(kontaktOsoba);
              KontaktOsoba ko = getKontaktOsobaById(kontaktOsoba.KontaktOsobaID);
               return new KontaktOsobaConfirmation
               {
                   KontaktOsobaID = ko.KontaktOsobaID,
                   Ime = ko.Ime,
                   Prezime= ko.Prezime
               }; 
              //return mapper.Map<KontaktOsobaConfirmation>(ko);*/

        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public KontaktOsobaConfirmation updateKontaktOsoba(KontaktOsoba kontaktOsoba)
        {
            
            KontaktOsoba ko = getKontaktOsobaById(kontaktOsoba.KontaktOsobaID);
             ko.KontaktOsobaID = kontaktOsoba.KontaktOsobaID;
             ko.Ime = kontaktOsoba.Ime;
             ko.Prezime = kontaktOsoba.Prezime;
             ko.Funkcija = kontaktOsoba.Funkcija;
             ko.Telefon = kontaktOsoba.Telefon;
             return new KontaktOsobaConfirmation
             {
                 KontaktOsobaID = ko.KontaktOsobaID,
                 Ime = ko.Ime,
                 Prezime = ko.Prezime
             }; 
        }
    }
}
