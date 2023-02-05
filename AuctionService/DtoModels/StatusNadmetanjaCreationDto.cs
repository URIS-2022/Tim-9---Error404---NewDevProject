using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class StatusNadmetanjaCreationDto
	{
		[Key]
        [Required(ErrorMessage = "Required field")]
        public string naziv { get; set; }
	}
}

