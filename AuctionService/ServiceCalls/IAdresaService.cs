using System;
using AuctionService.DtoModels;

namespace AuctionService.ServiceCalls
{
	public interface IAdresaService
	{
		Task<AdresaDto> getAdresa(Guid adresaId);
	}
}

