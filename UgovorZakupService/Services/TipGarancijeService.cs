using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UgovorZakupService.DtoModels;
using UgovorZakupService.Entities;
using UgovorZakupService.Repository;

namespace UgovorZakupService.Services
{
    public class TipGarancijeService : ITipGarancijeRepository
    {
        private readonly UgovorOZakupuContext context;
        private readonly IMapper mapper;
        public static List<TipGarancije> tipoviGarancije { get; set; } = new List<TipGarancije>();
        public TipGarancijeService(IMapper mapper, UgovorOZakupuContext context) 
        {
            this.context = context;
            this.mapper = mapper;
            FillData();
        }

        private void FillData()
        {
            tipoviGarancije.AddRange(new List<TipGarancije>
            {
                new Entities.TipGarancije
                {
                    tipGarancijeID = Guid.Parse("{382E2313-F5AD-4931-A126-6194BDAA071A}"),
                    nazivTipaGarancije = "Tip 1"
                },
                new Entities.TipGarancije
                {
                    tipGarancijeID = Guid.Parse("{DACDC2B3-3480-42AB-B467-6AE0B75DF207}"),
                    nazivTipaGarancije = "Tip 2"
                }
            });
        }

        public TipGarancijeConfirmationDto CreateTipGarancije(TipGarancije tipGarancije)
        {
            tipGarancije.tipGarancijeID = Guid.NewGuid();
            tipoviGarancije.Add(tipGarancije);
            TipGarancijeConfirmationDto conformationDto = mapper.Map<TipGarancijeConfirmationDto>(tipGarancije);
            return conformationDto;
        }

        public void DeleteTipGarancije(Guid id)
        {
            Entities.TipGarancije statusTG = GetTipGarancijeById(id);
            tipoviGarancije.Remove(statusTG);
        }

        public List<TipGarancije> GetAllTipGarancije()
        {
            return (from tg in tipoviGarancije select tg).ToList();
            //return context.tipoviGarancije.ToList();
        }

        public TipGarancije GetTipGarancijeById(Guid id)
        {
            return tipoviGarancije.FirstOrDefault(tipGarancije => tipGarancije.tipGarancijeID == id);
        }

        public bool SaveChanges()
        {
            return true;
        }

        public TipGarancijeConfirmationDto UpdateTipGarancije(TipGarancije tipGarancije)
        {
            throw new NotImplementedException();
        }
    }
}
