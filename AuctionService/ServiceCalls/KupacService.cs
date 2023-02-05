using System;
using AuctionService.DtoModels;

namespace AuctionService.ServiceCalls
{
	public class KupacService : IKupacService
	{
		public KupacService()
		{
		}

        public Task<KupacDto> getKupci(Guid kupacId)
        {
            KupacDto kupac = new KupacDto();
            kupac.kupacID = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");
            kupac.fizickoPravnoLice = true;
            kupac.osvarenaPovrsina = "255";
            kupac.zabrana = true;
            kupac.pocetakZabrane = DateTime.Parse("10-10-2022");
            kupac.duzinaZabrane = 3;
            kupac.prestanakZabrane = DateTime.Parse("10-10-2022");
            kupac.ovlascenoLiceId = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");
            kupac.prioritetId = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");
            kupac.brRacuna = "99999";
            kupac.brTel1 = "000";
            kupac.brTel2 = "4444";
            kupac.email = "andric@gmail.com";
            kupac.lice = "lice";
            kupac.adresaId = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");

            return Task.FromResult<KupacDto>(kupac);
        }
    }
}

