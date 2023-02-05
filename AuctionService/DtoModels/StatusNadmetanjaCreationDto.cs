using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class StatusNadmetanjaCreationDto
	{
        /// <summary>
        /// Naziv statusa nadmetanja
        /// </summary>
        /// 
        [Key]
        [Required(ErrorMessage = "Required field")]
        public string naziv { get; set; }
	}
}

