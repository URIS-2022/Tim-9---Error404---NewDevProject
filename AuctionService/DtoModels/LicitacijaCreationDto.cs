using System;
using System.ComponentModel.DataAnnotations;

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

        public Guid javnoNadmetanjeId { get; set; }

        public DateTime rokZaDostavljanje { get; set; }
    }
}

