using System;
namespace AuctionService.DtoModels
{
	public class KupacDto
	{
		public Guid KupacID { get; set; }

		public bool fizickoPravnoLice { get; set; }

		public string osvarenaPovrsina { get; set; }

		public bool zabrana { get; set; }

		public DateTime pocetakZabrane { get; set; }

		public int duzinaZabrane { get; set; }

		public DateTime prestanakZabrane { get; set; }

		public Guid? ovlascenoLiceId { get; set; } //moze biti i null ukoliko nema nikoga da ga zastupa

		public Guid	prioritetId { get; set; }

		public string lice { get; set; }

		public string brTel1 { get; set; }

        public string brTel2 { get; set; }

		public string adresaId { get; set; }

		public string uplataId { get; set; }

		public string email { get; set; }

		public string brRacuna { get; set; }
    }
}

