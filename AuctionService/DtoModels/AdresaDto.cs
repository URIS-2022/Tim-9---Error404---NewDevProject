using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class AdresaDto
	{
			[Key]
			public Guid adresaId { get; set; }
			public string ulica { get; set; }
			public string broj { get; set; }
			public string mesto { get; set; }
			public string postanskiBroj { get; set; }
			public string Drzava { get; set; }

		
	}
}

