using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class OvlascenoLiceDto
	{
		[Key]
		public Guid ovlascenoLiceId { get; set; }
		public string ime { get; set; }
		public string prezime { get; set; }
		public List<Guid> licaZaKojaVrsiLicitaciju { get; set; }
		public List<int> brojTabli { get; set; }
	}
}

