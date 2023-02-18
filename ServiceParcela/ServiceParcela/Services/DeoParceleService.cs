using AutoMapper;
using ServiceParcela.DtoModels;
using ServiceParcela.Entities;
using ServiceParcela.Repositories;
using System.Xml.Linq;

namespace ServiceParcela.Services
{
    public class DeoParceleService  : IDeoParceleRepository
    {
        public static List<DeoParcele> deoParceles { get; set; } = new List<DeoParcele>();
        private readonly IMapper mapper;
        private readonly ParcelaContex context;

        public DeoParceleService(IMapper mapper, ParcelaContex context)
        {
            this.mapper = mapper;
            this.context = context;
            // FillData();
        }
        /*
        private void FillData()
        {
            deoParceles.AddRange(new List<DeoParcele>
            {
                new DeoParcele
                {
                    deoParceleID = Guid.Parse("5d5a016a-b9c8-4bcd-9824-eec0106b32a8"),
                    parcelaID = Guid.Parse("b6194c5f-217a-40a4-99c2-5430096d02db"),
                    idealniDeoParcele = 40,
                    stvarniDeoParcele = 60
                },
                new DeoParcele
                {
                    deoParceleID = Guid.Parse("61d33f97-6b7e-4aa6-adc5-c307e0da50c3"),
                    parcelaID = Guid.Parse("b6194c5f-217a-40a4-99c2-5430096d02db"),
                    idealniDeoParcele = 55,
                    stvarniDeoParcele = 45
                }
            });
        }
        */

        public void deleteDeoParcele(Guid id)
        {
            Entities.DeoParcele deoParcele = getDeoParceleByID(id);
            context.deloviParcele.Remove(deoParcele);
        }

        public List<DeoParcele> getAllDeoParcele()
        {
            return context.deloviParcele.ToList();
        }

        public DeoParcele getDeoParceleByID(Guid id)
        {
            return context.deloviParcele.FirstOrDefault(deoParcele => deoParcele.deoParceleID == id);


        }

        public DeoParceleDto postDeoParcele(DeoParcele deoParcele)
        {
            deoParcele.deoParceleID = Guid.NewGuid();
            var novoDP = context.Add(deoParcele);
            return mapper.Map<DeoParceleDto>(novoDP.Entity);

            //throw new NotImplementedException();
        }

        public bool saveChanges()
        {
            return context.SaveChanges() > 1;
           // return true;
        }
        
        public DeoParceleDto putDeoParcele(DeoParcele deoParcele)
        {
            throw new NotImplementedException();
        }
    }
}
