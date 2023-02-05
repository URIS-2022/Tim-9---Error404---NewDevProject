using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class TipJavnogNadmetanjaConformationDto
	{
        /// <summary>
        /// Id tipa nadmetanja
        /// </summary>
        /// 
        [Key]
		public Guid tipJavnogNadmetanjaID { get; set; }
	}
}

