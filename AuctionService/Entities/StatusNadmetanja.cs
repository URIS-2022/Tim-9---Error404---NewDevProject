using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.Entities
{
	public class StatusNadmetanja
	{
		//ID status javnog nadmetanja
		[Key]
		public Guid statusNadmetanjaID { get; set; }

		public string naziv { get; set; }
	}
}

