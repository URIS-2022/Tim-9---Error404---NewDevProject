using System;
using AuctionService.DtoModels;
using AuctionService.Entities;
using AuctionService.Repository;
using AutoMapper;
namespace AuctionService.Services
{
	public class JavnoNadmetanjeService : IJavnoNadmetanjeRepository
	{
        private readonly JavnoNadmetanjeContext javnoNadmetanjeContext;
        private readonly IMapper mapper;

		public JavnoNadmetanjeService(JavnoNadmetanjeContext context, IMapper mapper)
		{
            this.javnoNadmetanjeContext = context;
            this.mapper = mapper;
		}

        public void deleteJavnoNadmetanje(Guid id)
        {
            Entities.JavnoNadmetanje jn = getJavnoNadmetanjeByID(id);
            javnoNadmetanjeContext.Remove(jn);
        }

        public List<JavnoNadmetanje> getJavnaNadmetanja()
        {
            return javnoNadmetanjeContext.javnoaNadmetanja.ToList();
        }

        public JavnoNadmetanje getJavnoNadmetanjeByID(Guid id)
        {
            return javnoNadmetanjeContext.javnoaNadmetanja.FirstOrDefault(jn => jn.javnoNadmetanjeID ==s id);
        }

        public JavnoNadmetanjeConformationDto postJavnoNadmetanje(JavnoNadmetanje jn)
        {
            jn.javnoNadmetanjeID = Guid.NewGuid();
            var novoJN = javnoNadmetanjeContext.Add(jn);
            return mapper.Map<JavnoNadmetanjeConformationDto>(novoJN.Entity);

        }

        public bool saveChanges()
        {
            return javnoNadmetanjeContext.SaveChanges() > 0;
        }

        public JavnoNadmetanjeConformationDto updateJavnoNadmetanje(JavnoNadmetanje jn)
        {
            throw new NotImplementedException();
        }
    }
}

