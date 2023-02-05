using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.DtoModels
{
	public class TipJavnogNadmetanjaConformationDto
	{
		[Key]
		//id tipa javog nadmetanja
		public Guid tipJavnogNadmetanjaID { get; set; }
	}
}

