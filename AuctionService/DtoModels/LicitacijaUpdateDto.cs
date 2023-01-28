using System;
namespace AuctionService.DtoModels
{
	public class LicitacijaUpdateDto
	{
        public Guid licitacijaId { get; set; }

        public int broj { get; set; }

        public int godina { get; set; }

        public DateTime datum { get; set; }

        public int ogranicenja { get; set; }

        public int korakCene { get; set; }

        public Guid javnoNadmetanjeId { get; set; }

        public DateTime rokPrijava { get; set; }
    }
}

