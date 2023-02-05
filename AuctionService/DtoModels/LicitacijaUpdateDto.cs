using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.DtoModels
{
	public class LicitacijaUpdateDto
	{
        [Key]
        public Guid licitacijaID { get; set; }

        public int broj { get; set; }

        public int godina { get; set; }

        public DateTime datum { get; set; }

        public int ogranicenja { get; set; }

        public int korakCene { get; set; }

        [ForeignKey("JavnoNadmetanje")]
        public Guid javnoNadmetanjeId { get; set; }

        public DateTime rokZaDostavljanje { get; set; }
    }
}

