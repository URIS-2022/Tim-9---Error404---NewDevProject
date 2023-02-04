using System;
using KorisnikService.DtoModels;
using KorisnikService.Entities.cs;
using KorisnikService.Repositories;

namespace KorisnikService.Service 
{
    public class TipKorisnikaService : ITipKorisnikaRepository
    {
        List<TipKorisnika> tipKorisnikas { get; set; } = new List<TipKorisnika>();
        public TipKorisnikaService() {
            FillData();
            
        }

        private void FillData()
        {
            tipKorisnikas.AddRange(new List<TipKorisnika>
            {
                new TipKorisnika
                {
                    tipKorisnikaId = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
                    uloga = "uloga1"
                },
                new TipKorisnika
                {
                    tipKorisnikaId = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82e"),
                    uloga = "uloga1"
                }
            });
        }

        public List<TipKorisnika> getAllTipoviKorisnika()
        {
            return (from tk in tipKorisnikas select tk).ToList();
        }

        public TipKorisnika getTipKorisnikaById(Guid id)
        {
            return tipKorisnikas.FirstOrDefault(tk => tk.tipKorisnikaId == id);
        }

        public void deleteTipKorisnika(Guid id)
        {
            TipKorisnika tk = getTipKorisnikaById(id);
            tipKorisnikas.Remove(tk);
        }

        public void updateTipKorisnika(TipKorisnika tipKorisnika)
        {
            throw new NotImplementedException();
        }

        public TipKorisnika postTipKorisnika(TipKorisnika tipKorisnika)
        {
            tipKorisnika.tipKorisnikaId = Guid.NewGuid();
            tipKorisnikas.Add(tipKorisnika);
            return tipKorisnika;
        }

        public bool SaveChanges()
        {
            return true;
        }

        
	}
}

