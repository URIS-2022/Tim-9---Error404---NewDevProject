﻿using Dokumenti_Service.Entities.Dokument;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dokumenti_Service.Models
{
    public class DokumentDTO
    {
        public Guid dokumentId { get; set; }

        /// <summary>
        /// zavodniBroj - broj registracije 
        /// Exaple: 1123232323
        /// </summary>
        public string zavodniBroj { get; set; }

        /// <summary>
        /// datumKreiranjaDokumenta - Datum krairanja dokumenta
        /// </summary>
        public DateTime? datumKreiranjaDokumenta { get; set; }

        /// <summary>
        /// DatumDokumenta - Datum u dokumenta 
        /// </summary>
        public DateTime? datumDokumenta { get; set; }

        /// <summary>
        /// sablon - Šablon dokumenta
        /// </summary>
        public string sablon { get; set; }

        /// <summary>
        /// statusDokumenta - Status dokumenta 
        /// </summary>

        public Guid dokumentStatusID { get; set; }
        

    }
}

