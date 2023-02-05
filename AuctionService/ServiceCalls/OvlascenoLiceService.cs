using System;
using AuctionService.DtoModels;

namespace AuctionService.ServiceCalls
{
	public class OvlascenoLiceService : IOvlascenoLiceService
	{
		public OvlascenoLiceService()
		{
		}

        public Task<OvlascenoLiceDto> getOvlascenoLice(Guid ovlascenoL)
        {
            OvlascenoLiceDto ovlascenoLice = new OvlascenoLiceDto();
            ovlascenoLice.ovlascenoLiceId = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");
            ovlascenoLice.ime = "Valentina";
            ovlascenoLice.prezime = "Andric";
            ovlascenoLice.brojTabli = new List<int> { 1, 2, 3 };

            return Task.FromResult<OvlascenoLiceDto>(ovlascenoLice);
        }
    }
}

