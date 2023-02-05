using System;
using AuctionService.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.DtoModels
{
	public class JavnoNadmetanjeUpdateDto
	{
        /// <summary>
        /// Id javnog nadmetanja
        /// </summary>
        /// 
        //primatrni kljuc javnog nadmetanja
        [Key]
        public Guid javnoNadmetanjeID { get; set; }

        /// <summary>
        /// Datum javnog nadmetanja
        /// </summary>
        /// 
        //datum javnog nadmetanja
        public DateTime datum { get; set; }

        /// <summary>
        /// Vreme pocetka javnog nadmetanja
        /// </summary>
        /// 
        //vreme pocetka javnog nadmetanja
        public DateTime vremePocetka { get; set; }

        /// <summary>
        /// Vreme kraja javnog nadmetanja
        /// </summary>
        /// 
        //vreme kraja javnog nadmetanja
        public DateTime vremeKraja { get; set; }

        /// <summary>
        /// Pocetna cena po hektaru 
        /// </summary>
        /// 
        //pocetna cena po hekraru
        public int pocetnaCenaPoHektaru { get; set; }

        /// <summary>
        /// Da li je jn izuzeto ili ne
        /// </summary>
        /// 
        //Izuzeto sa javnog nadmetanja
        public bool izuzeto { get; set; }

        /// <summary>
        /// Izlicitirana cena na javnom nadmetanju
        /// </summary>
        /// 
        //izlicitirana cena
        public int izlicitiranaCena { get; set; }

        /// <summary>
        /// Period zakupa parcele
        /// </summary>
        /// 
   
        public int periodZakupa { get; set; }

        /// <summary>
        /// Broj ucesnika na javnom nadmetanju
        /// </summary>
        /// 
        //broj ucesnika u licitaciji
        public int brojUcesnika { get; set; }

        /// <summary>
        /// Visina dopune depozita
        /// </summary>
        /// 
        //visina dopune depozita
        public int visinaDopuneDepozita { get; set; }

        /// <summary>
        /// Krug javnog nadmetanja
        /// </summary>
        /// 
        //krug nadmetanja
        public int krug { get; set; }

        //Lista parcela koje se nalaze na tom javnom nadmetanju

        /// <summary>
        /// ID statusa nadetanja
        /// </summary>
        /// 
        //status nadmetanja 
        [ForeignKey("StatusNadmetanja")]
        public Guid statusNadmetanjaID { get; set; }
        public StatusNadmetanja statusID { get; set; }

        /// <summary>
        /// Id tipa nadmetanja
        /// </summary>
        /// 
        [ForeignKey("TipJavnogNadmetanja")]
        public Guid tipID { get; set; }
        public TipJavnogNadmetanja tipJavnogNadmetanja { get; set; }

        /// <summary>
        /// Id ovlascenog lica 
        /// </summary>
        /// 
        
        [ForeignKey("OvlascenoLice")]
        public Guid ovlascenoLiceID { get; set; }

        /// <summary>
        /// Lista id-jeva prijavljenih kupaca
        /// </summary>
        /// 
        
        [ForeignKey("Kupac")]
        public List<Guid> prijavljeniKupciID { get; set; }

        /// <summary>
        /// Adresa odrzavanja nadmetanja
        /// </summary>
        /// 
        //Adresa odrzavnja nadmetanja
        [ForeignKey("Adresa")]
        public Guid adresaID { get; set; }
        

        /// <summary>
        /// Id najboljeg ponudjaca
        /// </summary>
        /// 
        [ForeignKey("Kupac")]
        public Guid najboljiPonudjacID { get; set; }

        /// <summary>
        /// Lista id-jeva parcela na javnom nadmetanju
        /// </summary>
        /// 
        [ForeignKey("Parcela")]
        public List<Guid> parceleID { get; set; }


    }
}

