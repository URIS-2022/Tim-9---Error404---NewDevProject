using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class StatusNadmetanjaCreationDto
	{
        [Required(ErrorMessage = "Requires field")]
        public string statusNadmetanja { get; set; }
	}
}

