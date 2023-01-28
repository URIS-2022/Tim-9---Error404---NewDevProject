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

        [Required(ErrorMessage = "Obavezno je uneti vreme kraja")]
        public DateTime vremeKraja { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti pocetnu cenu po hektaru")]
        public int pocetnaCenaPoHektaru { get; set; }

        [Required(ErrorMessage = "Obazeno je uneti da li je javno nadmetanje izuzeto")]
        public bool izuzeto { get; set; }

        [Required(ErrorMessage = "Obavezno uneti izlicitiranu cenu")]
        public int izlicitiranaCena { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti period zakupa")]
        public int periodZakupa { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti period zakupa")]
        public int brojUcesnika { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti dopunu visine depozita")]
        public int visinaDopuneDepozita { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti krug licitacije")]
        public int krug { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti status")]
        public Guid statusID { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti ovlasceno lice")]
        public Guid ovlascenoLiceID { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti adresu")]
        public Guid adresaID { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti najboljeg ponudjaca")]
        public Guid najboljiPonudjacID { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti tip licitacije")]
        public Guid tipID { get; set; }

 
    }
}

