using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class TipNadmetanjaCreationDto
	{
		[Required(ErrorMessage = "Requires field")]
		public string nazivTipa { get; set; }
	}
}

