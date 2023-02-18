using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;
using System.Xml.Linq;

namespace ServiceParcela.Services
{
    public class KulturaService  : IKulturaRepository
    {
        public static List<Kultura> kulturas { get; set; } = new List<Kultura>();
        private readonly IMapper mapper;
        private readonly ParcelaContex context;

        public KulturaService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            // FillData();
        }
        /*
        private void FillData()
        {
            kulturas.AddRange(new List<Kultura>
            {
                new Kultura
                {
                    kulturaID = Guid.Parse("1af29038-928a-46c1-9bee-3d0532b04dea"),
                    nazivKulture = "Njive"
                },
                new Kultura
                {
                    kulturaID = Guid.Parse("42b48292-0521-4caa-bb61-46a8cbdb9d3a"),
                    nazivKulture = "Vrtovi"
                },
                new Kultura
                {
                    kulturaID = Guid.Parse("e41f48a3-97a3-4093-b375-0b352b2e3802"),
                    nazivKulture = "Voćnjaci"
                },
                new Kultura
                {
                    kulturaID = Guid.Parse("29517569-fd26-48dd-a646-0b52790ca6f2"),
                    nazivKulture = "Vinogradi"
                },
                new Kultura
                {
                    kulturaID = Guid.Parse("b846877d-225d-45f6-a926-0a9def92e7f4"),
                    nazivKulture = "Livade"
                },
                new Kultura
                {
                    kulturaID = Guid.Parse("0245a22d-684b-4e81-8395-08dfe8c6dac8"),
                    nazivKulture = "Pašnjaci"
                },
                new Kultura
                {
                    kulturaID = Guid.Parse("055e4525-4401-455a-b5a7-7080803e9efb"),
                    nazivKulture = "Šume"
                },
                new Kultura
                {
                    kulturaID = Guid.Parse("2d4eeed9-0e71-42cb-8da1-1957f470a1ff"),
                    nazivKulture = "Trstici-močvare"
                }
            });
        }
        */

        public void deleteKultura(Guid id)
        {
            Entities.Kultura kultura = getKulturaByID(id);
            context.kulture.Remove(kultura);
        }

        public List<Kultura> getAllKultura()
        {
            return context.kulture.ToList();
        }

        public Kultura getKulturaByID(Guid id)
        {
            return context.kulture.FirstOrDefault(kultura => kultura.kulturaID == id);

        }

        public KulturaDto postKultura(Kultura kultura)
        {
            kultura.kulturaID = Guid.NewGuid();
            var novaKUL = context.kulture.Add(kultura);
            return mapper.Map<KulturaDto>(kultura);
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public KulturaDto putKultura(Kultura kultura)
        {
            throw new NotImplementedException();
        }
    }
}
