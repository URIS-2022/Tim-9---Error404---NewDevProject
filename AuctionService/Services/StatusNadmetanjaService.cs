using System;
using AuctionService.DtoModels;
using AuctionService.Entities;
using AuctionService.Repository;
using AutoMapper;

namespace AuctionService.Services
{
	public class StatusNadmetanjaService : IStatusNadmetanjaRepository
	{
        private readonly JavnoNadmetanjeContext context;
        private readonly IMapper mapper;

		public StatusNadmetanjaService(JavnoNadmetanjeContext context, IMapper mapper) 
		{
            this.mapper = mapper;
            this.context = context;
		}

        //delete status jn
        public void deleteStatusNadmetanja(Guid id)
        {
            Entities.StatusNadmetanja stausJN = getStatusNadmetanjaByID(id);
            context.statusiNadmetanja.Remove(stausJN);

        }

        //get all status jn
        public List<StatusNadmetanja> getAllStatusiNadmetanja()
        {
            return context.statusiNadmetanja.ToList();
        }

        //get status jn by id
        public StatusNadmetanja getStatusNadmetanjaByID(Guid id)
        {
            return context.statusiNadmetanja.FirstOrDefault(statusJN => statusJN.statusNadmetanjaID == id);
        }

        //post status jn
        public StatusNadmetanjaConformationDto postStatusNadmetanja(StatusNadmetanja status)
        {
            status.statusNadmetanjaID = Guid.NewGuid();
            var noviStatus = context.statusiNadmetanja.Add(status);
            return mapper.Map<StatusNadmetanjaConformationDto>(noviStatus.Entity);
        }

        //save changes
        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public StatusNadmetanjaConformationDto updateStatusNadmetanja(StatusNadmetanja status)
        {
            throw new NotImplementedException();
        }
    }
}

