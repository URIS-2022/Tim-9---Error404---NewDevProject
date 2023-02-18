using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;

namespace ServiceParcela.Services
{
    public class ParcelaService : IParcelaRepository
    {
        public static List<Parcela> parcelas { get; set; } = new List<Parcela>();
        private readonly IMapper mapper;
        private readonly ParcelaContex context;

        public ParcelaService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            //   FillData();
        }
        /*
        private void FillData()
        {
            parcelas.AddRange(new List<Parcela>
            {
                new Parcela
                {
                    parcelaID = Guid.Parse("b6194c5f-217a-40a4-99c2-5430096d02db"),
                    povrsina = 1152,
                    brojParcele = "123",
                    katastarskaOpstinaID = Guid.Parse("b41c324d-a885-46ce-93c6-2cf38df6c679"),
                    brojListaNepokretnosti = "23",
                    kulturaID = Guid.Parse("1af29038-928a-46c1-9bee-3d0532b04dea"),
                    obradivostID = Guid.Parse("e3c5f27b-8757-4026-8131-19c127395922"),
                    zasticenaZonaID = Guid.Parse("9aa1cd9b-6e6c-4a9e-8840-641070ab5246"),
                    oblikSvojineID = Guid.Parse("ac2a129f-03da-4e0c-9ad6-5ab63f13a8b5"),
                    odvodnjavanjeID = Guid.Parse("389eab9c-5869-4745-a838-0b9211c227a3"),
                    obradivostStvarnoStanje = "da",
                    kulturaStvarnoStanje = "da",
                    klasaStvarnoStanje = "da",
                    zasticenaZonaStvarnoStanje = "da",
                    odvodnjavanjeStvarnoStanje = "da"
                },
                new Parcela
                {
                    parcelaID = Guid.Parse("ed20eaf8-65ff-4a29-a564-ad7cfc08f7a2"),
                    povrsina = 1362,
                    brojParcele = "124",
                    katastarskaOpstinaID = Guid.Parse("c4e673a1-b52b-4f09-afe4-2d8cd0612ffa"),
                    brojListaNepokretnosti = "43",
                    kulturaID = Guid.Parse("42b48292-0521-4caa-bb61-46a8cbdb9d3a"),
                    obradivostID = Guid.Parse("70928335-ad90-4a80-b672-99319f915698"),
                    zasticenaZonaID = Guid.Parse("0ff62375-b94c-4415-9ae0-096bb738b8bc"),
                    oblikSvojineID = Guid.Parse("235cfc03-763b-4ed2-9353-65a0898d6ab0"),
                    odvodnjavanjeID = Guid.Parse("bfd7815f-b9d8-4032-bfcf-9c400c49bc99"),
                    obradivostStvarnoStanje = "da",
                    kulturaStvarnoStanje = "da",
                    klasaStvarnoStanje = "da",
                    zasticenaZonaStvarnoStanje = "da",
                    odvodnjavanjeStvarnoStanje = "da"
                }
            });
        }
        */
        public void deleteParcela(Guid id)
        {
            Parcela parcela = getParcelaByID(id);
            context.parcele.Remove(parcela);
        }

        public List<Parcela> getAllParcela()
        {
            return context.parcele.ToList();
        }

        public Parcela getParcelaByID(Guid id)
        {
            return context.parcele.FirstOrDefault(parcela => parcela.parcelaID == id); ;
        }

        public ParcelaDto postParcela(Parcela parcela)
        {
            parcela.parcelaID = Guid.NewGuid();
            var novaP = context.parcele.Add(parcela);
            return mapper.Map<ParcelaDto>(parcela);
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public ParcelaDto putParcela(Parcela parcela)
        {
            throw new NotImplementedException();
        }
    }
}
