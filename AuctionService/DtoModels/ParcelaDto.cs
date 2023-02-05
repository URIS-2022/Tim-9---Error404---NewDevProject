using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class ParcelaDto
	{
		[Key]
		public Guid parcelaId { get; set; }
	}
}

