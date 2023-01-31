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
	[Route("api/statusiNadmetanja")]
	[Produces("application/xml", "application/json")]
	public class StatusNadmetanjaController : ControllerBase
	{
		private readonly IStatusNadmetanjaRepository statusNadmetanjaRepository;
		private readonly IMapper mapper;
		private readonly string name = "Status_nadmetanja";


		public StatusNadmetanjaController(IStatusNadmetanjaRepository statusNadmetanjaService, IMapper mapper)
		{
			this.statusNadmetanjaRepository = statusNadmetanjaService;
			this.mapper = mapper;
		}

		[HttpGet]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<List<StatusNadmetanjaDto>> getAllStatusiNadmetanja()
		{
			List<Entities.StatusNadmetanja> statusiNadmetanja = statusNadmetanjaRepository.getAllStatusiNadmetanja();

			if (statusiNadmetanja == null || statusiNadmetanja.Count == 0)
			{
				return NoContent();
			}

			List<StatusNadmetanjaDto> statusiNadmetanjaDto = mapper.Map<List<StatusNadmetanjaDto>>(statusiNadmetanja);

			return Ok(mapper.Map<List<StatusNadmetanjaDto>>(statusiNadmetanjaDto));
		}

		[HttpGet("{statusNadmetanjaId}")]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<StatusNadmetanjaDto> getStatusNadmetanjaById(Guid statusNadmetanjaId)
		{
			Entities.StatusNadmetanja statusNadmetanja = statusNadmetanjaRepository.getStatusNadmetanjaByID(statusNadmetanjaId);

			if (statusNadmetanja == null)
			{
				return NotFound();
			}

			StatusNadmetanjaDto statusNadmetanjaDto = mapper.Map<StatusNadmetanjaDto>(statusNadmetanja);

			return Ok(mapper.Map<StatusNadmetanjaDto>(statusNadmetanjaDto));
		}

		[HttpDelete("{statusNadmetanjaId}")]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult deleteStatusNadmetanja(Guid statusNadmetanjaId)
		{
			try
			{
				Entities.StatusNadmetanja statusNadmetanja = statusNadmetanjaRepository.getStatusNadmetanjaByID(statusNadmetanjaId);

				if (statusNadmetanja == null)
				{
					return NotFound();
				}

				statusNadmetanjaRepository.deleteStatusNadmetanja(statusNadmetanjaId);
				statusNadmetanjaRepository.SaveChanges();
				return NoContent();

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Delete error");
			}

		}

		[HttpPut]
		[Consumes("application/json")]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<StatusNadmetanjaConformationDto> updateStatusNadmetanja(StatusJavnogNadmetanjaUpdateDto statusNadmetanjaDto)
		{
			try
			{
				Entities.StatusNadmetanja oldStatusNadetanja = statusNadmetanjaRepository.getStatusNadmetanjaByID(statusNadmetanjaDto.statusNadmetanjaID);

				if (oldStatusNadetanja == null)
				{
					return NotFound();
				}
				Entities.StatusNadmetanja statusNadmetanja = mapper.Map<Entities.StatusNadmetanja>(statusNadmetanjaDto);
				mapper.Map(statusNadmetanja, oldStatusNadetanja);
				statusNadmetanjaRepository.SaveChanges();
				return Ok(mapper.Map<StatusNadmetanjaConformationDto>(oldStatusNadetanja));

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Update error");
			}
		}

		[HttpPost]
		[Consumes("application/json")]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<StatusNadmetanjaConformationDto> postStatusNadmetanja([FromBody] StatusNadmetanjaCreationDto statusNadmetanjaDto)
		{
			try
			{
				Entities.StatusNadmetanja statusNadmetanja = mapper.Map<Entities.StatusNadmetanja>(statusNadmetanjaDto);
				statusNadmetanjaRepository.postStatusNadmetanja(statusNadmetanja);
				statusNadmetanjaRepository.SaveChanges();
				return Created("uri", mapper.Map<StatusNadmetanjaConformationDto>(statusNadmetanja));

			}
			catch
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Post error");
			}
		}
	}


}

