using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class StatusNadmetanjaConformationDto
	{
        /// <summary>
        /// Id statusa nadmetanja
        /// </summary>
        /// 
        //get status id
        [Key]
		public Guid statusNadmetanjaID { get; set; }
	}
}

