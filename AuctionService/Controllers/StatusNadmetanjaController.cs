using System;
using AuctionService.DtoModels;
using AuctionService.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers
{
	[ApiController]
	[Route("statusiNadmetanja")]
	[Produces("application/xml", "application/json")]
	public class StatusNadmetanjaController : ControllerBase
	{
		private readonly StatusNadmetanjaService statusNadmetanjaService;
		private readonly IMapper mapper;
		private readonly string name = "Status_nadmetanja";


		public StatusNadmetanjaController(StatusNadmetanjaService statusNadmetanjaService, IMapper mapper)
		{
			this.statusNadmetanjaService = statusNadmetanjaService;
			this.mapper = mapper;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<List<StatusNadmetanjaDto>> getAllStatusiNadmetanja()
		{
			List<Entities.StatusNadmetanja> statusiNadmetanja = statusNadmetanjaService.getAllStatusiNadmetanja();

			if(statusiNadmetanja == null || statusiNadmetanja.Count == 0)
			{
				return NoContent();
			}

			List<StatusNadmetanjaDto> statusiNadmetanjaDto = mapper.Map<List<StatusNadmetanjaDto>>(statusiNadmetanja);

			return Ok(mapper.Map<List<StatusNadmetanjaDto>>(statusiNadmetanjaDto));
		}

		[HttpGet("satusNadmetanjaId")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<StatusNadmetanjaDto> getStatusNadmetanjaById(Guid statusNadmetanjaId)
		{
			Entities.StatusNadmetanja statusNadmetanja = statusNadmetanjaService.getStatusNadmetanjaByID(statusNadmetanjaId);

			if(statusNadmetanja == null)
			{
				return NotFound();
			}

			StatusNadmetanjaDto statusNadmetanjaDto = mapper.Map<StatusNadmetanjaDto>(statusNadmetanja);

			return Ok(statusNadmetanjaDto);
		}

		[HttpDelete("statusNadmetanjaId")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult deleteStatusNadmetanja (Guid statusNadmetanjaId)
		{
			try
			{
                Entities.StatusNadmetanja statusNadmetanja = statusNadmetanjaService.getStatusNadmetanjaByID(statusNadmetanjaId);

                if (statusNadmetanja == null)
                {
                    return NotFound();
                }

                statusNadmetanjaService.deleteStatusNadmetanja(statusNadmetanjaId);
                statusNadmetanjaService.SaveChanges();
				return NoContent();

            }catch(Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Delete error");
			}
			
		}

		[HttpPut("statusNadmetanjaDto")]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<StatusNadmetanjaConformationDto> updateStatusNadmetanja(StatusJavnogNadmetanjaUpdateDto statusNadmetanjaDto)
		{
			try
			{
				Entities.StatusNadmetanja oldStatusNadetanja = statusNadmetanjaService.getStatusNadmetanjaByID(statusNadmetanjaDto.statusNadmetanjaId);

				if(oldStatusNadetanja == null)
				{
					return NotFound();
				}
				Entities.StatusNadmetanja statusNadmetanja = mapper.Map<Entities.StatusNadmetanja>(statusNadmetanjaDto);
				mapper.Map(statusNadmetanja, oldStatusNadetanja);
				statusNadmetanjaService.SaveChanges();
				return Ok(mapper.Map<StatusNadmetanjaConformationDto>(oldStatusNadetanja));

			}
			catch(Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Update error");
			}
		}
	}

	
}

