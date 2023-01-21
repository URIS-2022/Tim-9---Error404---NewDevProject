using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionService.Entities
{
	public class Kupac
	{
		[Key]
		public Guid kupacID { get; set; }

		//ime koupca
		public string ime { get; set; }

		//prezime kupca
		public string prezime { get; set; }

		//email kupca
		public string email { get; set; }

		//korisnicko ime korisnika
		public string korisnickoIme { get; set; }

		//sifra korisnika
		public string password { get; set; }

		//Salt
		public string salt { get; set; }
	}
}

