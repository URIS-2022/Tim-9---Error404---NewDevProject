using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities
{
	public class Licitacija
	{
		[Key]
		public Guid licitacijaID { get; set; }

		public int broj { get; set; }

		public int godina { get; set; }

		public DateTime datum { get; set; }

		public int ogranicenja { get; set; }

		public int korakCene { get; set; }

		[NotMapped]
		public List<string> listaDokumentacijeFizickaLica { get; set; }

		[NotMapped]
		public List<string> listaDokumentacijePravnaLica { get; set; }

		[ForeignKey("javnoNadmetanje")]
		public Guid javnoNadmetanjeId{ get; set; }
		public JavnoNadmetanje javnoNadmetanje { get; set; }

		public DateTime rokZaDostavljanje { get; set; }

	}
}

