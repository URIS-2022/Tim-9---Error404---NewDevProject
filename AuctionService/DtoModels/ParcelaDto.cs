using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class ParcelaDto
	{
        /// <summary>
        /// Id parcele
        /// </summary>
        /// 
        [Key]
		public Guid parcelaId { get; set; }
	}
}

