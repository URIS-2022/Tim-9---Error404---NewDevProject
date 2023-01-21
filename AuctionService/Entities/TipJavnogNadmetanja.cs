using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.Entities
{
	public class TipJavnogNadmetanja
	{
		[Key]
		public Guid tipJavnogNadmetanjaID;

		//naziv tipa javnog nadmetanja
		public string nazivTipa { get; set; }
	}
}

