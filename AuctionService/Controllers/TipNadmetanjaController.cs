using System;
using AuctionService.DtoModels;
using AuctionService.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers
{
	[ApiController]
	[Route("api/tipoviNadmetanja")]
	[Produces("application/json", "application/xml")]
	public class TipJavnogNadmetanjaController : ControllerBase
	{
		private readonly TipNadmetanjaService tipNadmetanjaService;
		private readonly IMapper mapper;
		private readonly string naziv = "Tip_javnog_nadmetanja";

		public TipJavnogNadmetanjaController(TipNadmetanjaService tipNadmetanjaService,IMapper mapper, string naziv )
		{
			this.tipNadmetanjaService = tipNadmetanjaService;
			this.mapper = mapper;
		}

		[HttpGet]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<List<TipNadmetanjaDto>> getAllTipoviNadmetanja()
		{
			List<Entities.TipJavnogNadmetanja> tipoviNadmetanja = tipNadmetanjaService.getAllTipoviJavnogNadmetanja();

			if(tipoviNadmetanja == null || tipoviNadmetanja.Count == 0)
			{
				return NoContent();
			}

			//ovde samo ceo objekat namapirmao na dto objekat klase
			List<TipNadmetanjaDto> tipoviNadmetanjaDto = mapper.Map<List<TipNadmetanjaDto>>(tipoviNadmetanja);

			//prolazimo kroz te objekte i returnujemo ih
			return Ok(mapper.Map<List<TipNadmetanjaDto>>(tipoviNadmetanjaDto));
		}

		[HttpGet("tipNadmetanjaId")]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<TipNadmetanjaDto> geTipJavnogNadmetanjaById(Guid tipNadmetanjaId)
		{
			Entities.TipJavnogNadmetanja tipNadmetanja = tipNadmetanjaService.getTipJavnogNadmetanjaById(tipNadmetanjaId);

			if(tipNadmetanja == null)
			{
				return NotFound();
			}

			TipNadmetanjaDto tipJnDto = mapper.Map<TipNadmetanjaDto>(tipNadmetanja);

			return Ok(tipJnDto);
		}

		[HttpDelete("tipNadmetanjaId")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult deleteTipNadmetanja(Guid tipNadmetanjaId)
		{
			try
			{
				Entities.TipJavnogNadmetanja tipNadmetanja = tipNadmetanjaService.getTipJavnogNadmetanjaById(tipNadmetanjaId);

				if (tipNadmetanja == null)
				{
					return NotFound();
				}

				tipNadmetanjaService.deleteTipJavnogNadmetanja(tipNadmetanjaId);
				tipNadmetanjaService.SaveChanges();
				return NoContent();

			}
			catch(Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Delete error");
			}
			
		}

		[HttpPut]
		[Consumes("application/json")]
		[ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TipJavnogNadmetanjaConformationDto> putTipJavnogNadmetanja(TipJavnogNadmetanjaUpdateDto tipNadmetanjaDto)
		{
			try
			{
				Entities.TipJavnogNadmetanja oldTipJn = tipNadmetanjaService.getTipJavnogNadmetanjaById(tipNadmetanjaDto.tipNadmetanjaId);

				if(oldTipJn == null)
				{
					return NotFound();
				}

				Entities.TipJavnogNadmetanja tipJavnogNadmetanja = mapper.Map<Entities.TipJavnogNadmetanja>(tipNadmetanjaDto);
				mapper.Map(tipJavnogNadmetanja, oldTipJn);
				tipNadmetanjaService.SaveChanges();
				return Ok(mapper.Map<TipJavnogNadmetanjaConformationDto>(oldTipJn));
			}
			catch(Exception ex)
			{
				return (StatusCode(StatusCodes.Status500InternalServerError, "Put error"));
			}

		}
	}
}

