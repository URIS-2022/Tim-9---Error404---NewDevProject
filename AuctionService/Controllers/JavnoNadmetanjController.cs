using System;
using System.Collections.Generic;
using AuctionService.DtoModels;
using AuctionService.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers
{
    [ApiController]
	[Route("api/javnaNadmetanja")]
	[Produces("application/json", "application/xml")]
    public class JavnoNadmetanjController : ControllerBase
	{
		private readonly JavnoNadmetanjeService javnoNadmetanjeService;
		private readonly KupacService kupacService;
		private readonly IMapper mapper;
		private readonly string name = "Javno_nadmetanje_service";
		

		public JavnoNadmetanjController(JavnoNadmetanjeService javnoNadmetanjeService, KupacService kupacService, IMapper mapper, string name)
		{
			this.javnoNadmetanjeService = javnoNadmetanjeService;
			this.kupacService = kupacService;
			this.mapper = mapper;
			this.name = name;
		}
		[HttpGet]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		public ActionResult<List<JavnoNadmetanjeDto>> getAllJavnaNadmetanja()
		{
			List<Entities.JavnoNadmetanje> javnaNadmetanja = javnoNadmetanjeService.getJavnaNadmetanja();
			if(javnaNadmetanja == null || javnaNadmetanja.Count == 0)
			{
				return NoContent();
			}

			List<JavnoNadmetanjeDto> javnoNadmetanjeDto = mapper.Map<List<JavnoNadmetanjeDto>>(javnaNadmetanja);

			return Ok(mapper.Map<List<JavnoNadmetanjeDto>>(javnoNadmetanjeDto));
		}

		[HttpGet]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<JavnoNadmetanjeDto> getJavnoNadmetanjeById(Guid id)
		{
			Entities.JavnoNadmetanje jn = javnoNadmetanjeService.getJavnoNadmetanjeByID(id);
			 if (jn == null)
			{
				return NotFound();
			}

			JavnoNadmetanjeDto jnDto = mapper.Map<JavnoNadmetanjeDto>(jn);
			return Ok(jnDto);
		}

		[HttpDelete("javnoNadmetanjeID")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult deleteJavnoNadmetanje (Guid javnoNadmetanjeID)
		{
			try
			{
                Entities.JavnoNadmetanje jn = javnoNadmetanjeService.getJavnoNadmetanjeByID(javnoNadmetanjeID);

                if (jn == null)
                {
                    return NotFound();
                }

                javnoNadmetanjeService.deleteJavnoNadmetanje(javnoNadmetanjeID);
                javnoNadmetanjeService.saveChanges();
                return NoContent();
            }catch(Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Delete error");
			}
			
		}

		//put method
		[HttpPut]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public ActionResult<JavnoNadmetanjeConformationDto> putJavnoNadmetanje (JavnoNadmetanjeUpdateDto jnDto)
		{
			try
			{
				Entities.JavnoNadmetanje oldJn = javnoNadmetanjeService.getJavnoNadmetanjeByID(jnDto.javnoNadmetanjeId);

				if(oldJn == null)
				{
					return NotFound();
				}

				Entities.JavnoNadmetanje javnoNadmetanje = mapper.Map<Entities.JavnoNadmetanje>(jnDto);
				mapper.Map(javnoNadmetanje, oldJn);
				javnoNadmetanjeService.saveChanges();
				return Ok(mapper.Map<JavnoNadmetanjeConformationDto>(oldJn));
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Update error");
			}
		}

		public ActionResult<JavnoNadmetanjeConformationDto> postJavnoNadmetnanje([FromBody] JavnoNadmetanjeDto)
		{

		}
	}
}

