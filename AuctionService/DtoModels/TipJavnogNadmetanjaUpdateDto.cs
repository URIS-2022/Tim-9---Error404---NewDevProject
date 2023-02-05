using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class TipJavnogNadmetanjaUpdateDto
	{
		[Key]
		public Guid tipJavnogNadmetanjaID { get; set; }

		public string nazivTipa { get; set; }
	}
}

