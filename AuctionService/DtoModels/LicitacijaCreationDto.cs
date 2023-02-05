using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.DtoModels
{
	public class LicitacijaCreationDto
	{
        [Required(ErrorMessage = "Obavezno je uneti broj licitacije")]
        public int broj { get; set; }

        public int godina { get; set; }

        public DateTime datum { get; set; }

        public int ogranicenja { get; set; }

        public int korakCene { get; set; }

        [ForeignKey("JavnoNadmetanje")]
        public Guid javnoNadmetanjeId { get; set; }

        public DateTime rokZaDostavljanje { get; set; }
    }
}

