using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;
using System.Xml.Linq;

namespace ServiceParcela.Services
{
    public class OblikSvojineService : IOblikSvojineRepository
    {
        public static List<OblikSvojine> oblikSvojines { get; set; } = new List<OblikSvojine>();
        private readonly IMapper mapper;
        private readonly ParcelaContex context;

        public OblikSvojineService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            // FillData();
        }
        /*
        private void FillData()
        {
            oblikSvojines.AddRange(new List<OblikSvojine>
            {
                new OblikSvojine
                {
                    oblikSvojineID = Guid.Parse("e174e16d-07ef-43fd-9063-02e6cbc268ca"),
                    nazivOblikaSvojine = "Privatna svojina"
                },
                new OblikSvojine
                {
                    oblikSvojineID = Guid.Parse("81878ece-4026-40cb-9cf5-077193071211"),
                    nazivOblikaSvojine = "Državna svojina RS"
                },
                new OblikSvojine
                {
                    oblikSvojineID = Guid.Parse("ff6aca81-f31b-406e-b90a-f176882e74e8"),
                    nazivOblikaSvojine = "Državna svojina"
                },
                new OblikSvojine
                {
                    oblikSvojineID = Guid.Parse("a828ee07-dac0-44a4-9448-d85a67e4ccf1"),
                    nazivOblikaSvojine = "Društvena svojina"
                },
                new OblikSvojine
                {
                    oblikSvojineID = Guid.Parse("235cfc03-763b-4ed2-9353-65a0898d6ab0"),
                    nazivOblikaSvojine = "Zadružna svojina"
                },
                new OblikSvojine
                {
                    oblikSvojineID = Guid.Parse("09d1cc19-a993-491e-8bc1-2481f9475a1e"),
                    nazivOblikaSvojine = "Mešovita svojina"
                },
                new OblikSvojine
                {
                    oblikSvojineID = Guid.Parse("ac2a129f-03da-4e0c-9ad6-5ab63f13a8b5"),
                    nazivOblikaSvojine = "Drugi oblici"
                }
            });
        }
        */

        public void deleteOblikSvojine(Guid id)
        {
            Entities.OblikSvojine oblikSvojine = getOblikSvojineByID(id);
            context.obliciSvojine.Remove(oblikSvojine);
        }

        public List<OblikSvojine> getAllOblikSvojine()
        {
            return context.obliciSvojine.ToList();
        }

        public OblikSvojine getOblikSvojineByID(Guid id)
        {
            return context.obliciSvojine.FirstOrDefault(oblikSvojine => oblikSvojine.oblikSvojineID == id);

        }

        public OblikSvojineDto postOblikSvojine(OblikSvojine oblikSvojine)
        {
            oblikSvojine.oblikSvojineID = Guid.NewGuid();
            var noviOS = context.obliciSvojine.Add(oblikSvojine);
            return mapper.Map<OblikSvojineDto>(oblikSvojine);

            //throw new NotImplementedException();
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public OblikSvojineDto putOblikSvojine(OblikSvojine oblikSvojine)
        {
            throw new NotImplementedException();
        }
    }
}