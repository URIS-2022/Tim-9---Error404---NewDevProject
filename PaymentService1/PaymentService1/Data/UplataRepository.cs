using AutoMapper;
using PaymentService1.Entities;

namespace PaymentService1.Data
{
    public class UplataRepository : IUplataRepository
    {
        public static List<Uplata> uplatas { get; set; } = new List<Uplata>();
        private readonly IMapper mapper;
        private readonly UplataContext context;

        public UplataRepository(IMapper mapper, UplataContext context)
        {
           // FillData();
            this.mapper = mapper;
            this.context = context;
        }
        /*
        private void FillData()
        {
            uplatas.AddRange(new List<Uplata>
            {
                new Uplata
                {
                    UplataID= Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939"),
                    brojRacuna= "111111",
                    pozivNaBroj= "56562654",
                    iznos= 9999,
                    uplatilac= Guid.Parse("dd03a193-323c-4db3-a472-813af4f37559"),
                    svrhaUplate= "svrha",
                    datum= DateTime.Parse("2022-2-25"),
                    javnoNadmetanje= Guid.Parse("4920c355-23ca-41b2-8eee-b34f4b7f9e5a")
                },
                new Uplata
                {
                    UplataID= Guid.Parse("0713e837-4be6-4d49-b749-5ec2d87c3301"),
                    brojRacuna= "22222",
                    pozivNaBroj= "1223361235",
                    iznos= 8888,
                    uplatilac= Guid.Parse("b274e9ac-ec75-4f23-8b68-ad42373f7fb8"),
                    svrhaUplate= "svrha2",
                    datum= DateTime.Parse("2022-2-20"),
                    javnoNadmetanje= Guid.Parse("58976698-c453-493e-b01e-687f862ba76a")
                }
            }) ;
        }*/

        public void deleteUplata(Guid id)
        {
            Entities.Uplata uplata = getUplataById(id);
            context.uplate.Remove(uplata);
        }

        public List<Uplata> getAllUplate()
        {
            return context.uplate.ToList();
        }

        public Uplata getUplataById(Guid id)
        {
            return context.uplate.FirstOrDefault(u => u.UplataID == id);
        }

        public UplataConfirmation postUplata(Uplata uplata)
        {
            uplata.UplataID = Guid.NewGuid();
            var novaU = context.uplate.Add(uplata);
            return mapper.Map<UplataConfirmation>(uplata);
            /*uplata.UplataID = Guid.NewGuid();
            uplatas.Add(uplata);
            Uplata u = getUplataById(uplata.UplataID);
            return new UplataConfirmation
            {
                UplataID = u.UplataID,
                brojRacuna = u.brojRacuna,
                iznos = u.iznos,
                uplatilac= u.uplatilac,
                datum= u.datum
            };*/
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public UplataConfirmation updateUplata(Uplata uplata)
        {
            Uplata u = getUplataById(uplata.UplataID);
            u.UplataID = uplata.UplataID;
            u.brojRacuna = uplata.brojRacuna;
            u.pozivNaBroj = uplata.pozivNaBroj;
            u.iznos = uplata.iznos;
            u.uplatilac = uplata.uplatilac;
            u.svrhaUplate = uplata.svrhaUplate;
            u.datum = uplata.datum;
            u.javnoNadmetanje = uplata.javnoNadmetanje;
            return new UplataConfirmation
            {
                UplataID = u.UplataID,
                brojRacuna = u.brojRacuna,
                iznos = u.iznos,
                uplatilac = u.uplatilac,
                datum = u.datum
            };
        }
    }
}
