using System;
using AuctionService.DtoModels;
using AuctionService.Entities;
using AuctionService.Repository;
using AutoMapper;

namespace AuctionService.Services
{
	public class TipNadmetanjaService : ITipNadmetanjaRepository 
	{
        public static List<TipJavnogNadmetanja> tipJavnogNadmetanjas { get; set; } = new List<TipJavnogNadmetanja>();
        private readonly JavnoNadmetanjeContext context;
        private readonly IMapper mapper;

		public TipNadmetanjaService(JavnoNadmetanjeContext context, IMapper mapper)
		{
            this.mapper = mapper;
            this.context = context;
            FillData();
		}

        private void FillData()
        {
            tipJavnogNadmetanjas.AddRange(new List<TipJavnogNadmetanja>
            {
                new TipJavnogNadmetanja
                {
                    tipJavnogNadmetanjaID = Guid.Parse("4246a611-7b2f-429d-a9ba-0e539c81b82f"),
                    nazivTipa = "Javna licitacija"
                },
                new TipJavnogNadmetanja
                {
                    tipJavnogNadmetanjaID = Guid.Parse("99b6d6ec-4358-4898-936b-31b31d236324"),
                    nazivTipa = "Otvaranje zatvorenih ponuda"
                }
            });
        }


        public void deleteTipJavnogNadmetanja(Guid id)
        {
            Entities.TipJavnogNadmetanja tipJn = getTipJavnogNadmetanjaById(id);
            context.tipoviNadmetanja.Remove(tipJn);
        }

        public List<TipJavnogNadmetanja> getAllTipoviJavnogNadmetanja()
        {
            // return context.tipoviNadmetanja.ToList();
            return (from t in tipJavnogNadmetanjas select t).ToList();
        }

        public TipJavnogNadmetanja getTipJavnogNadmetanjaById(Guid id)
        {
            return context.tipoviNadmetanja.FirstOrDefault(tipJn => tipJn.tipJavnogNadmetanjaID == id);
        }

        public TipJavnogNadmetanjaConformationDto postTipJavnogNadmetanja(TipJavnogNadmetanja tipJN)
        {
            tipJN.tipJavnogNadmetanjaID = Guid.NewGuid();
            var noviTip = context.tipoviNadmetanja.Add(tipJN);
            return mapper.Map<TipJavnogNadmetanjaConformationDto>(noviTip.Entity);
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public TipJavnogNadmetanjaConformationDto updateTipJavnogNadmetanja(TipJavnogNadmetanja tipJN)
        {
            throw new NotImplementedException();
        }
    }
}

