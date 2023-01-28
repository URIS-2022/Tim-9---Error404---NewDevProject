using System;
using AuctionService.DtoModels;
using AuctionService.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers
{
	public class LicitacijaController : ControllerBase
	{
		private readonly IMapper mapper;
		private readonly LicitacijaService licitacijaService;
		private readonly string name = "Licitacija_service";

		public LicitacijaController(IMapper mapper, string name, LicitacijaService licitacijaService)
		{
			this.mapper = mapper;
			this.licitacijaService = licitacijaService;
			this.name = name;
		}

		

		[HttpPut]
		[Consumes("application/json")]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<LicitacijaConformationDto> updateLicitacija (LicitacijaUpdateDto licitacijaDto)
		{
			try
			{
                Entities.Licitacija oldLicitacija = licitacijaService.getLicitacijaById(licitacijaDto.licitacijaId);

                if (oldLicitacija == null)
                {
                    return NotFound();
                }

                Entities.Licitacija licitacija = mapper.Map<Entities.Licitacija>(licitacijaDto);
                mapper.Map(licitacija, oldLicitacija);
                licitacijaService.saveChanges();
                return Ok(mapper.Map<LicitacijaConformationDto>(oldLicitacija));
			}
			catch
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Update error");
			}
			
		}
	}
}

