using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;
using System.Xml.Linq;

namespace ServiceParcela.Services
{
    public class KatastarskaOpstinaService : IKatastarskaOpstinaRepository
    {
        public static List<KatastarskaOpstina> katastarskaOpstinas { get; set; } = new List<KatastarskaOpstina>();

        private readonly IMapper mapper;
        private readonly ParcelaContex context;

        public KatastarskaOpstinaService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            // FillData();
        }
        /*
        private void FillData()
        {
            katastarskaOpstinas.AddRange(new List<KatastarskaOpstina>
            {
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("b41c324d-a885-46ce-93c6-2cf38df6c679"),
                    nazivKatastarskeOpstine = "Čantavir"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("c4e673a1-b52b-4f09-afe4-2d8cd0612ffa"),
                    nazivKatastarskeOpstine = "Bački Vinogradi"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("807391fc-b3f1-4b69-a6a7-c48d54585387"),
                    nazivKatastarskeOpstine = "Bikovo"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("9514b1b3-0d7a-49ae-80ba-46f9df420083"),
                    nazivKatastarskeOpstine = "Đuđin"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("2a366ea1-1141-4d68-a544-3bbdcfb153ba"),
                    nazivKatastarskeOpstine = "Žednik"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("3c13042d-4c28-470b-b512-b6d1bc2c343e"),
                    nazivKatastarskeOpstine = "Tavankut"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("d351326d-624e-454d-b459-e4b145a2b3c8"),
                    nazivKatastarskeOpstine = "Bajmok"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("954d582c-134f-462e-b634-d4eb99d76369"),
                    nazivKatastarskeOpstine = "Donji Grad"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("1a1de9ad-916b-4b43-adda-d5a1783c4a8d"),
                    nazivKatastarskeOpstine = "Stari Grad"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("5c6c9e3b-ddba-4cf9-ae71-eceed1f41989"),
                    nazivKatastarskeOpstine = "Novi Grad"
                },
                new KatastarskaOpstina
                {
                    katastarskaOpstinaID = Guid.Parse("c1ef2536-0329-4cc9-b8a9-307e6a259471"),
                    nazivKatastarskeOpstine = "Palić"
                }
            });
        }*/

        public void deleteKatastarskaOpstina(Guid id)
        {
            Entities.KatastarskaOpstina katastarskaOpstina = getKatastarskaOpstinaByID(id);
            context.katastarskeOpstine.Remove(katastarskaOpstina);
        }

        public List<KatastarskaOpstina> getAllKatastarskaOpstina()
        {
            return context.katastarskeOpstine.ToList();
        }

        public KatastarskaOpstina getKatastarskaOpstinaByID(Guid id)
        {
            return context.katastarskeOpstine.FirstOrDefault(katastarskaOpstina => katastarskaOpstina.katastarskaOpstinaID == id);

        }

        public KatastarskaOpstinaDto postKatastarskaOpstina(KatastarskaOpstina katastarskaOpstina)
        {
            katastarskaOpstina.katastarskaOpstinaID = Guid.NewGuid();
            var novaKO = context.katastarskeOpstine.Add(katastarskaOpstina);
            return mapper.Map<KatastarskaOpstinaDto>(katastarskaOpstina);
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public KatastarskaOpstinaDto putKatastarskaOpstina(KatastarskaOpstina katastarskaOpstina)
        {
            throw new NotImplementedException();
        }
    }
}
