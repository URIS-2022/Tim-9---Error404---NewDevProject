using CustomerService1.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerService1.Entities
{
    public class Kupac
    {
        public Guid KupacID { get; set; }
        public bool FizPravno { get; set; }
        public string OstvarenaPovrsina { get; set; }
        public bool Zabrana { get; set; }
        public DateTime PocetakZabrane { get; set; }
        public string DuzinaZabrane { get; set; }
        public DateTime PrestanakZabrane { get; set; }
        public Guid? OvlascenoLiceID { get; set; }
        public Guid PrioritetID { get; set; }
        public string BrTel1 { get; set; }
        public string BrTel2 { get; set; }
        public Guid AdresaID { get; set; }
        public Guid UplataID { get; set; }
        public string Email { get; set; }
        public string BrojRacuna { get; set; }

        [NotMapped]
        public OvlascenoLiceDto OvlascenoLice { get; set; }
        [NotMapped]
        public UplataDto Uplata { get; set; }
        [NotMapped]
        public AdresaDto Adresa { get; set; }

    }
}
