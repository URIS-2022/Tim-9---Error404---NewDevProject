using System;
using AuctionService.DtoModels;

namespace AuctionService.ServiceCalls
{
	public interface IAdresaService
	{
        /// <summary>
        /// Metoda za komunikaciju sa adresa servisom
        /// </summary>
        Task<AdresaDto> getAdresa(Guid adresaId);
	}
}

