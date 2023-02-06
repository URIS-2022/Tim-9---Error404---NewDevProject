using System;
using AuctionService.DtoModels;
using AuctionService.Entities;
using AuctionService.Repository;
using AutoMapper;

namespace AuctionService.Services
{
    public class StatusNadmetanjaService : IStatusNadmetanjaRepository
    {
        private readonly JavnoNadmetanjeContext context;
        private readonly IMapper mapper;
        public static List<StatusNadmetanja> statusNadmetanjas { get; set; } = new List<StatusNadmetanja>();

        public StatusNadmetanjaService(IMapper mapper, JavnoNadmetanjeContext context)
        {
            this.mapper = mapper;
           // FillData();
            this.context = context;
        }

        //private void FillData()
        //{
        //    statusNadmetanjas.AddRange(new List<StatusNadmetanja>
        //    {
        //        new StatusNadmetanja
        //        {
        //            statusNadmetanjaID = Guid.Parse("8aaa90c8-56f3-4a76-b07a-f895eded5a84"),
        //            naziv = "Prvi krug"
        //        },
        //        new StatusNadmetanja
        //        {
        //            statusNadmetanjaID = Guid.Parse("b1ad846b-f76f-4485-8c89-08e2dfebd112"),
        //            naziv = "Drugi krug sa starim uslovima"
        //        },
        //        new StatusNadmetanja
        //        {
        //            statusNadmetanjaID = Guid.Parse("d85b4a71-27e4-4626-9a3e-0412430e03d6"),
        //            naziv = "Drugi krug sa novim uslovima"
        //        }
        //    });
        //}

        //delete status jn
        public void deleteStatusNadmetanja(Guid id)
        {
            Entities.StatusNadmetanja statusJN = getStatusNadmetanjaByID(id);
            // context.statusiNadmetanja.Remove(stausJN);
            statusNadmetanjas.Remove(statusJN);

        }

        //get all status jn
        public List<StatusNadmetanja> getAllStatusiNadmetanja()
        {
            return context.statusiNadmetanja.ToList();
           // return (from s in statusNadmetanjas select s).ToList();
        }

        //get status jn by id
        public StatusNadmetanja getStatusNadmetanjaByID(Guid id)
        {
            //return context.statusiNadmetanja.FirstOrDefault(statusJN => statusJN.statusNadmetanjaID == id);
            return statusNadmetanjas.FirstOrDefault(status => status.statusNadmetanjaID == id);
           
        }

        //post status jn
        public StatusNadmetanjaConformationDto postStatusNadmetanja(StatusNadmetanja status)
        {
            status.statusNadmetanjaID = Guid.NewGuid();
            //var noviStatus = context.statusiNadmetanja.Add(status);
            //return mapper.Map<StatusNadmetanjaConformationDto>(noviStatus.Entity);
            statusNadmetanjas.Add(status);
            StatusNadmetanjaConformationDto conformationDto = mapper.Map<StatusNadmetanjaConformationDto>(status);
            return conformationDto;
        }

        //save changes
        public bool SaveChanges()
        {
            //return context.SaveChanges() > 0;
            return true;
        }

        public StatusNadmetanjaConformationDto updateStatusNadmetanja(StatusNadmetanja status)
        {
            throw new NotImplementedException();
        }
    }
}

