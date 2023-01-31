using System;
using AuctionService.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class JavnoNadmetanjeCreationDto
	{
        [Required(ErrorMessage = "Obavezno je uneti datum")]
        public DateTime datum { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti vreme pocetka")]
        public DateTime vremePocetka { get; set; }
        
        public DateTime vremeKraja { get; set; }

        public int pocetnaCenaPoHektaru { get; set; }
       
        public bool izuzeto { get; set; }
     
        public int izlicitiranaCena { get; set; }
  
        public int periodZakupa { get; set; }
 
        public int brojUcesnika { get; set; }

        public int visinaDopuneDepozita { get; set; }

        public int krug { get; set; }

        public Guid statusNadmetanjaID { get; set; }

        public Guid ovlascenoLiceID { get; set; }

        public Guid adresaID { get; set; }

        public Guid najboljiPonudjacID { get; set; }

        public Guid tipID { get; set; }

 
    }
}

