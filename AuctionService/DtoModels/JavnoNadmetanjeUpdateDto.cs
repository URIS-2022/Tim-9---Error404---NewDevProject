using System;
namespace AuctionService.DtoModels
{
	public class JavnoNadmetanjeUpdateDto
	{
        public Guid javnoNadmetanjeID { get; set; }

        public DateTime datum { get; set; }

        public DateTime vremePocetka { get; set; }

        public DateTime vremeKraja { get; set; }

        public int pocetnaCena { get; set; }

        public bool izuzeto { get; set; }

        public Guid tipJavnogNadmetanjaID { get; set; }

        public int izlicitiranaCena { get; set; }

        public int periodZakupa { get; set; }

        public int brojUcesnika { get; set; }

        public int visinaDopuneDepozita { get; set; }

        public Guid kupacID { get; set; }

        public int krug { get; set; }

        public Guid statusNadmetanjaID { get; set; }

        public Guid ovlascenoLiceID { get; set; }

        public Guid adresaID { get; set; }


    }
}

