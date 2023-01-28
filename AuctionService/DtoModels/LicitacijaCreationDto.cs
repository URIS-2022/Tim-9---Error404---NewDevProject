using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class LicitacijaCreationDto
	{
        [Required(ErrorMessage = "Obavezno je uneti broj licitacije")]
        public int broj { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti godinu")]
        public int godina { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti datum")]
        public DateTime datum { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti ogranicenja")]
        public int ogranicenja { get; set; }

        [Required(ErrorMessage = "Obavezno je korak cene")]
        public int korakCene { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti javno nadmetanje")]
        public Guid javnoNadmetanjeId { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti rok prijava")]
        public DateTime rokPrijava { get; set; }
    }
}

