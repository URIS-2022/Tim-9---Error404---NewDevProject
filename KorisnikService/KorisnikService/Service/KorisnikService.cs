using System;
using KorisnikService.Entities.cs;
using KorisnikService.Repositories;

namespace KorisnikService.Service
{
    public class KorisnikService : IKorisnikRepository
    {

        public static List<Korisnik> korisniks { get; set; } = new List<Korisnik>();

        public KorisnikService()
        {
            FillData();
        }

        private void FillData()
        {
            korisniks.AddRange(new List<Korisnik>
            {
                new Korisnik
                {
                    korisnikId = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
                    tipKorisnikaId = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82b"),
                    ime = "Valenitna",
                    prezime = "Andric",
                    korisnickoIme = "andric@valentina@gmail.com",
                    lozinka = "lozinka",
                    salt = "salt"
                },
                new Korisnik
                {
                    korisnikId = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82c"),
                    tipKorisnikaId = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82d"),
                    ime = "Aleksandra",
                    prezime = "Vujovic",
                    korisnickoIme = "aleksandra@Vujovic.com",
                    lozinka = "lozinka",
                    salt = "salt"
                }
            });
        }

        public bool checkIfUserExist(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void deleteKorisnik(Guid id)
        {
            Korisnik korisnik = getKorisnikById(id);
            korisniks.Remove(korisnik);
        }

        public List<Korisnik> getAllKorisnici()
        {
            return (from k in korisniks select k).ToList();
        }

        public Korisnik getKorisnikById(Guid id)
        {
            return korisniks.FirstOrDefault(k => k.korisnikId == id);
        }

        public Korisnik postKorisnik(Korisnik korisnik)
        {
            korisnik.korisnikId = Guid.NewGuid();
            korisniks.Add(korisnik);
            return korisnik;
        }

        public bool SaveChanges()
        {
            return true;
        }

        public void updateKorisnik(Korisnik korisnik)
        {
            throw new NotImplementedException();

        }
    }
}


