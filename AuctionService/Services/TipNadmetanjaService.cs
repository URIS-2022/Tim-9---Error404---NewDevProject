using System;
using AuctionService.DtoModels;
using AuctionService.Entities;
using AuctionService.Repository;

namespace AuctionService.Services
{
	public class TipNadmetanjaService : ITipNadmetanjaRepository 
	{
		public TipNadmetanjaService()
		{
		}

        public void deleteTipJavnogNadmetanja(Guid id)
        {
            throw new NotImplementedException();
        }

        public TipJavnogNadmetanja getAllTipoviJavnogNadmetanja()
        {
            throw new NotImplementedException();
        }

        public TipJavnogNadmetanja GetTipJavnogNadmetanjaById(Guid id)
        {
            throw new NotImplementedException();
        }

        public TipJavnogNadmetanjaConformationDto postTipJavnogNadmetanja(TipJavnogNadmetanja tipJN)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public TipJavnogNadmetanjaConformationDto updateTipJavnogNadmetanja(TipJavnogNadmetanja tipJN)
        {
            throw new NotImplementedException();
        }
    }
}

