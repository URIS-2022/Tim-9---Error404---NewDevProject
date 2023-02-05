using System;
using AuctionService.DtoModels;

namespace AuctionService.ServiceCalls
{
	public interface IOvlascenoLiceService
	{
		Task<OvlascenoLiceDto> getOvlascenoLice(Guid ovlascenoLice);
	}
}

