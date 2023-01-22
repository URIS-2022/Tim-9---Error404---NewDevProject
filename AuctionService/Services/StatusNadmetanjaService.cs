using System;
using AuctionService.DtoModels;
using AuctionService.Entities;
using AuctionService.Repository;

namespace AuctionService.Services
{
	public class StatusNadmetanjaService : IStatusNadmetanjaRepository
	{
		public StatusNadmetanjaService() 
		{
		}

        public void deleteStatusNadmetanja(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<StatusNadmetanja> getAllStatusiNadmetanja()
        {
            throw new NotImplementedException();
        }

        public StatusNadmetanja getStatusNadmetanjaByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public StatusNadmetanjaConformationDto postStatusNadmetanja(StatusNadmetanja status)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public StatusNadmetanjaConformationDto updateStatusNadmetanja(StatusNadmetanja status)
        {
            throw new NotImplementedException();
        }
    }
}

