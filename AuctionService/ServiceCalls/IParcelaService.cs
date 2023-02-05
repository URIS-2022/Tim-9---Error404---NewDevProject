using System;
using AuctionService.DtoModels;

namespace AuctionService.ServiceCalls
{
	public interface IParcelaService
	{
		Task<ParcelaDto> getParcela(Guid parcelaId);
	}
}

