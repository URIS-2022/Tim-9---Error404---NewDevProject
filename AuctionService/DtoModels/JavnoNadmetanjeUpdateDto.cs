using System;
namespace AuctionService.DtoModels
{
	public class JavnoNadmetanjeUpdateDto
	{
        public Guid javnoNadmetanjeId { get; set; }

        public DateTime datum { get; set; }

        public DateTime vremePocetka { get; set; }

        public DateTime vremeKraja { get; set; }

        public int pocetnaCena { get; set; }

        public bool izuzeto { get; set; }

        public Guid tipJavnogNadmetanja { get; set; }

        public int izlicitiranaCena { get; set; }

        public int periodZakupa { get; set; }

        public int brojUcesnika { get; set; }

        public int visinaDopuneDepozita { get; set; }

        public Guid kupac { get; set; }

        public int krug { get; set; }

        public Guid statusNadmetanja { get; set; }

        public Guid ovlascenoLiceId { get; set; }

        public Guid adresaId { get; set; }


    }
}

