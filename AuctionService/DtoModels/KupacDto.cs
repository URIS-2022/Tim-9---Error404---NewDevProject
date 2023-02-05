using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class KupacDto
	{
        /// <summary>
        /// Id kupca
        /// </summary>
        /// 
        [Key]
		public Guid kupacID { get; set; }

        /// <summary>
        /// Da li je kupac fizicno ili pravno lice
        /// </summary>
        /// 
        public bool fizickoPravnoLice { get; set; }

        /// <summary>
        /// Ostvarena povrsina
        /// </summary>
        /// 
        public string osvarenaPovrsina { get; set; }

        /// <summary>
        /// Da li kupac ima zabranu
        /// </summary>
        /// 
		public bool zabrana { get; set; }

        /// <summary>
        /// Period zabrane
        /// </summary>
        /// 
		public DateTime pocetakZabrane { get; set; }

        /// <summary>
        /// Duzina trajanja zabrne
        /// </summary>
        /// 
		public int duzinaZabrane { get; set; }

        /// <summary>
        /// Prestanak zabrane
        /// </summary>
        /// 
		public DateTime prestanakZabrane { get; set; }

        /// <summary>
        /// Id ovlascenog lica
        /// </summary>
        /// 
		public Guid? ovlascenoLiceId { get; set; } //moze biti i null ukoliko nema nikoga da ga zastupa

        /// <summary>
        /// Id prioriteta kupca
        /// </summary>
        /// 
		public Guid	prioritetId { get; set; }

        /// <summary>
        /// Lice
        /// </summary>
        /// 
		public string lice { get; set; }

        /// <summary>
        /// Broj telefona
        /// </summary>
        /// 
		public string brTel1 { get; set; }

        /// <summary>
        /// Broj telefona
        /// </summary>
        /// 
        public string brTel2 { get; set; }

        /// <summary>
        /// Adresa kupca
        /// </summary>
        /// 
		public Guid adresaId { get; set; }

        /// <summary>
        /// Id uplate kupca
        /// </summary>
        /// 
		public string uplataId { get; set; }

        /// <summary>
        /// Email kupca
        /// </summary>
        /// 
		public string email { get; set; }

        /// <summary>
        /// Broj racuna kupca
        /// </summary>
        /// 
		public string brRacuna { get; set; }
    }
}

