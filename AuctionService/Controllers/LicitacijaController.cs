using System;
using AuctionService.DtoModels;
using AuctionService.Repository;
using AuctionService.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers
{
	[ApiController]
	[Route("api/licitacije")]
	[Produces("application/json", "application/xml")]
	public class LicitacijaController : ControllerBase
	{
		private readonly IMapper mapper;
		private readonly ILicitacijaRepository licitacijaRepository;
		private readonly string name = "Licitacija_service";

		public LicitacijaController(IMapper mapper, ILicitacijaRepository licitacijaService)
		{
			this.mapper = mapper;
			this.licitacijaRepository = licitacijaService;
		}



		[HttpPut]
		[Consumes("application/json")]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<LicitacijaConformationDto> updateLicitacija(LicitacijaUpdateDto licitacijaDto)
		{
			try
			{
				Entities.Licitacija oldLicitacija = licitacijaRepository.getLicitacijaById(licitacijaDto.licitacijaID);

				if (oldLicitacija == null)
				{
					return NotFound();
				}

				Entities.Licitacija licitacija = mapper.Map<Entities.Licitacija>(licitacijaDto);
				mapper.Map(licitacija, oldLicitacija);
				licitacijaRepository.saveChanges();
				return Ok(mapper.Map<LicitacijaConformationDto>(oldLicitacija));
			}
			catch
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Update error");
			}

		}

		//post method
		[HttpPost]
		[Consumes("application/json")]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<LicitacijaConformationDto> postLicitacija([FromBody] LicitacijaCreationDto licitacijaDto)
		{
			try
			{
				Entities.Licitacija licitacija = mapper.Map<Entities.Licitacija>(licitacijaDto);
				licitacijaRepository.postLicitacija(licitacija);
				licitacijaRepository.saveChanges();
				return Created("uri", mapper.Map<LicitacijaConformationDto>(licitacija));
			}
			catch
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Post error");
			}
		}

		[HttpGet]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		public ActionResult<List<LicitacijaDto>> getAllLicitacije()
		{
			List<Entities.Licitacija> licitacije = licitacijaRepository.getAllLicitacija();
			if (licitacije == null || licitacije.Count == 0)
			{
				return NoContent();
			}

			List<LicitacijaDto> licitacijeDto = mapper.Map<List<LicitacijaDto>>(licitacije);
			return Ok(mapper.Map<List<LicitacijaDto>>(licitacijeDto));
		}

        [HttpGet("{licitacijaId}")]
        [HttpHead]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<LicitacijaDto> getLicitacijaById(Guid licitacijaId)
        {
            Entities.Licitacija l = licitacijaRepository.getLicitacijaById(licitacijaId);
            if (l == null)
            {
                return NotFound();
            }

            LicitacijaDto lDto = mapper.Map<LicitacijaDto>(l);
            return Ok(lDto);
        }


        [HttpDelete("{licitacijaId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult deleteLicitacija(Guid licitacijaId)
        {
            try
            {
                Entities.Licitacija l = licitacijaRepository.getLicitacijaById(licitacijaId);

                if (l == null)
                {
                    return NotFound();
                }

                licitacijaRepository.deleteLicitacija(licitacijaId);
                licitacijaRepository.saveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Delete error");
            }

        }


    }
}

