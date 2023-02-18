using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;
using System.Xml.Linq;

namespace ServiceParcela.Services
{
    public class ObradivostService : IObradivostRepository
    {
        public static List<Obradivost> obradivosts { get; set; } = new List<Obradivost>();
        private readonly IMapper mapper;
        private readonly ParcelaContex context;

        public ObradivostService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            // FillData();
        }
        /*
        private void FillData()
        {
            obradivosts.AddRange(new List<Obradivost>
            {
                new Obradivost
                {
                    obradivostID = Guid.Parse("e3c5f27b-8757-4026-8131-19c127395922"),
                    nazivObradivosti = "Obradivo"
                },
                new Obradivost
                {
                    obradivostID = Guid.Parse("70928335-ad90-4a80-b672-99319f915698"),
                    nazivObradivosti = "Ostalo"
                }
            });
        }
        */
        public void deleteObradivost(Guid id)
        {
            Entities.Obradivost obradivost = getObradivostByID(id);
            context.obradivosti.Remove(obradivost);
        }

        public List<Obradivost> getAllObradivost()
        {
            return context.obradivosti.ToList();
        }

        public Obradivost getObradivostByID(Guid id)
        {
            return context.obradivosti.FirstOrDefault(obradivost => obradivost.obradivostID == id);

        }

        public ObradivostDto postObradivost(Obradivost obradivost)
        {
            obradivost.obradivostID = Guid.NewGuid();
            var novaOB = context.obradivosti.Add(obradivost);
            return mapper.Map<ObradivostDto>(obradivost);

            //throw new NotImplementedException();
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 0;
        }
        public ObradivostDto putObradivost(Obradivost obradivost)
        {
            throw new NotImplementedException();
        }
    }
}
