using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class StatusJavnogNadmetanjaUpdateDto
	{
		[Key]
		public Guid statusNadmetanjaID { get; set; }

		public string naziv {get; set;}
	}
}

