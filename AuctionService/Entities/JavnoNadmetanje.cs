using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AuctionService.DtoModels;

namespace AuctionService.Entities
{
	public class JavnoNadmetanje
	{
        
        //primatrni kljuc javnog nadmetanja
        [Key]
		public Guid javnoNadmetanjeID { get; set; }

		//datum javnog nadmetanja
		public DateTime datum { get; set; }

		//vreme pocetka javnog nadmetanja
		public DateTime vremePocetka { get; set; }

		//vreme kraja javnog nadmetanja
		public DateTime vremeKraja { get; set; }

		//pocetna cena po hekraru
		public int pocetnaCenaPoHektaru { get; set; }

		//Izuzeto sa javnog nadmetanja
		public bool izuzeto { get; set; }

		//izlicitirana cena
		public int izlicitiranaCena { get; set; }

		//period zakupa zemljista
		public int periodZakupa { get; set; }

		//broj ucesnika u licitaciji
		public int brojUcesnika { get; set; }

		//visina dopune depozita
		public int visinaDopuneDepozita { get; set; }

		//krug nadmetanja
		public int krug { get; set; }

		//Lista parcela koje se nalaze na tom javnom nadmetanju
		
		//status nadmetanja 
		[ForeignKey("StatusNadmetanja")]
		public Guid statusNadmetanjaID { get; set; }
        public StatusNadmetanja statusID { get; set; }

        [ForeignKey("TipJavnogNadmetanja")]
        public Guid tipID { get; set; }
        public TipJavnogNadmetanja tipJavnogNadmetanja { get; set; }

        //Ovlascena lica javnog nadmetanja (licitanti)
        [ForeignKey("OvlascenoLice")]
        public Guid ovlascenoLiceID { get; set; }

		//Prijavljeni kupci na javno nadmetanje
		[ForeignKey("Kupac")]
		public List<Guid> prijavljeniKupciID { get; set; }

		//Adresa odrzavnja nadmetanja
		[ForeignKey("Adresa")]
		public Guid adresaID {get; set;}
        //Najbolji ponudjac

        [ForeignKey("Kupac")]
        public Guid najboljiPonudjacID { get; set;}

		[ForeignKey("Parcela")]
        public List<Guid> parceleID { get; set; }

		[NotMapped]
		public OvlascenoLiceDto ovlascenoLice { get; set; }

		[NotMapped]
		public List<ParcelaDto> parcele { get; set; }

		[NotMapped]
		public KupacDto najboljiPonudjac { get; set; }

		[NotMapped]
		public List<KupacDto> prijavljeniKupci { get; set; }

		[NotMapped]
		public AdresaDto adreasa { get; set; }


    }
}

