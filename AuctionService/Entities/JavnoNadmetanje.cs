using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities
{
	public class JavnoNadmetanje
	{
        public StatusNadmetanja statusNadmetanja { get; set; }
		public TipJavnogNadmetanja tipJavnogNadmetanja { get; set; }

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
		[NotMapped]
		public List<Guid> parceleID { get; set; }

		//status nadmetanja 
		[ForeignKey("statusNadmetanjaID")]
		public Guid statusID { get; set; }
		
		//Ovlascena lica javnog nadmetanja (licitanti)
		public Guid ovlascenoLiceID { get; set; }

		//Prijavljeni kupci na javno nadmetanje
		[NotMapped]
		public List<Guid> prijavljeniKupciID { get; set; }

		//Adresa odrzavnja nadmetanja
		public Guid adresaID {get; set;}

		//Najbolji ponudjac
		public Guid najboljiPonudjacID { get; set;}

		//Tip nadmetanja
		[ForeignKey("tipJavnogNadmetanjaID")]
		public Guid tipID { get; set; }

	}
}

