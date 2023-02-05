using System;
using AuctionService.DtoModels;

namespace AuctionService.ServiceCalls
{
	public class ParcelaService : IParcelaService
	{
		public ParcelaService()
		{
		}

        public Task<ParcelaDto> getParcela(Guid parcelaId)
        {
            ParcelaDto parcela = new ParcelaDto();
            parcela.parcelaId = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");

            return Task.FromResult<ParcelaDto>(parcela);
        }
    }
}

