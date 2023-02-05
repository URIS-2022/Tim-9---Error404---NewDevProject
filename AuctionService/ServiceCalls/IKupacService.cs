using System;
using AuctionService.DtoModels;

namespace AuctionService.ServiceCalls
{
	public interface IKupacService
	{
		Task<KupacDto> getKupci(Guid kupacId);
	}
}

