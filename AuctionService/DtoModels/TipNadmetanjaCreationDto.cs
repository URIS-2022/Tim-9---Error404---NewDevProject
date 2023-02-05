using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class TipNadmetanjaCreationDto
	{
        /// <summary>
        /// Naziv tipa nadmetanja
        /// </summary>
        /// 
        [Required(ErrorMessage = "Requires field")]
		public string nazivTipa { get; set; }
	}
}

