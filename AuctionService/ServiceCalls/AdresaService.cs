using System;
using AuctionService.DtoModels;
using Newtonsoft.Json;

namespace AuctionService.ServiceCalls
{
	public class AdresaService : IAdresaService
	{
		public AdresaService()
		{
		}

        public Task<AdresaDto> getAdresa(Guid adresaId)
        {
            AdresaDto adresa = new AdresaDto();
            adresa.adresaId = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");
            adresa.broj = "3";
            adresa.Drzava = "Srbija";
            adresa.mesto = "Priboj";
            adresa.postanskiBroj = "31330";
            adresa.ulica = "Radnicka 18";

            return Task.FromResult<AdresaDto>(adresa);
        }
    }
}

