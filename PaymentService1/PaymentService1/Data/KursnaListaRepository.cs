using AutoMapper;
using PaymentService1.Entities;

namespace PaymentService1.Data
{
    public class KursnaListaRepository : IKursnaListaRepository
    {
        public static List<KursnaLista> kursnaListas { get; set; } = new List<KursnaLista>();
        private readonly IMapper mapper;
        private readonly UplataContext context;

        public KursnaListaRepository(IMapper mapper, UplataContext context)
        {
          //  FillData();
            this.mapper = mapper;
            this.context = context;
        }
        /*
        private void FillData()
        {
            kursnaListas.AddRange(new List<KursnaLista>
            {
                new KursnaLista
                {
                    KursnaListaID= Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939"),
                    datum= DateTime.Parse("2022-2-25"),
                    valuta= "Dolar",
                    vrednost= 100
                    
                },
                new KursnaLista
                {
                    KursnaListaID= Guid.Parse("1de13266-85e8-4120-8b1f-daacc32c5811"),
                    datum= DateTime.Parse("2022-2-25"),
                    valuta= "Evro",
                    vrednost= 117
                }
            });
        }*/

        public void deleteKurs(Guid id)
        {
            Entities.KursnaLista kursnaLista = getKursById(id);
            context.kursneListe.Remove(kursnaLista);
        }

        public List<KursnaLista> getAllKurs()
        {
            return context.kursneListe.ToList();
        }

        public KursnaLista getKursById(Guid id)
        {
            return context.kursneListe.FirstOrDefault(kl => kl.KursnaListaID == id);
        }

        public KursnaListaConfirmation postKurs(KursnaLista kurs)
        {
            kurs.KursnaListaID = Guid.NewGuid();
            var novaKL = context.kursneListe.Add(kurs);
            return mapper.Map<KursnaListaConfirmation>(kurs);
            /* kurs.KursnaListaID = Guid.NewGuid();
             kursnaListas.Add(kurs);
             KursnaLista kl = getKursById(kurs.KursnaListaID);
             return new KursnaListaConfirmation
             {
                 KursnaListaID = kl.KursnaListaID,
                 valuta = kl.valuta

             };*/
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public KursnaListaConfirmation updateKurs(KursnaLista kurs)
        {
            KursnaLista kl = getKursById(kurs.KursnaListaID);
            kl.KursnaListaID = kurs.KursnaListaID;
            kl.datum= kurs.datum;
            kl.valuta = kurs.valuta;
            kl.vrednost = kurs.vrednost;
            return new KursnaListaConfirmation
            {
                KursnaListaID = kl.KursnaListaID,
                valuta = kl.valuta
            };
        }
    }
}
