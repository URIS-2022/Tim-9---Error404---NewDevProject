using System;
using System.Collections.Generic;
using AuctionService.DtoModels;
using AuctionService.Repository;
using AuctionService.ServiceCalls;
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
		private readonly IJavnoNadmetanjeRepository javnoNadmetanjeRepository;
		//private readonly KupacService kupacService;
		private readonly IMapper mapper;
		private readonly string name = "Javno_nadmetanje_service";
		private readonly IAdresaService adresaService;
		private readonly IOvlascenoLiceService ovlascenoLiceService;
		private readonly IKupacService kupacService;
		private readonly IParcelaService parcelaService;


		public JavnoNadmetanjController(IJavnoNadmetanjeRepository javnoNadmetanjeRepository, IMapper mapper, IAdresaService adresaService, IOvlascenoLiceService ovlascenoLiceService, IKupacService kupacService, IParcelaService parcelaService)
		{
			this.javnoNadmetanjeRepository = javnoNadmetanjeRepository;
			this.mapper = mapper;
			this.adresaService = adresaService;
			this.ovlascenoLiceService = ovlascenoLiceService;
			this.parcelaService = parcelaService;
			this.kupacService = kupacService;
			
		
		}
		[HttpGet]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		public ActionResult<List<JavnoNadmetanjeDto>> getAllJavnaNadmetanja()
		{
			List<Entities.JavnoNadmetanje> javnaNadmetanja = javnoNadmetanjeRepository.getJavnaNadmetanja();
			if (javnaNadmetanja == null || javnaNadmetanja.Count == 0)
			{
				return NoContent();
			}


			List<JavnoNadmetanjeDto> javnoNadmetanjeDto = mapper.Map<List<JavnoNadmetanjeDto>>(javnaNadmetanja);

			foreach(JavnoNadmetanjeDto jn in javnoNadmetanjeDto)
			{
                jn.adreasa = adresaService.getAdresa(jn.adresaID).Result;
				jn.ovlascenoLice = ovlascenoLiceService.getOvlascenoLice(jn.ovlascenoLiceID).Result;
				foreach(Guid parcela in jn.parceleID)
				{
					jn.parcele.Add(parcelaService.getParcela(parcela).Result);
				}

				foreach(Guid kupci in jn.prijavljeniKupciID)
				{
					jn.prijavljeniKupci.Add(kupacService.getKupci(kupci).Result);
				}
				
			}

			return Ok(mapper.Map<List<JavnoNadmetanjeDto>>(javnoNadmetanjeDto));
		}

		[HttpGet("{javnoNadmetanjeId}")]
		[HttpHead]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult<JavnoNadmetanjeDto> getJavnoNadmetanjeById(Guid javnoNadmetanjeId)
		{
			Entities.JavnoNadmetanje jn = javnoNadmetanjeRepository.getJavnoNadmetanjeByID(javnoNadmetanjeId);
			if (jn == null)
			{
				return NotFound();
			}

			JavnoNadmetanjeDto jnDto = mapper.Map<JavnoNadmetanjeDto>(jn);
			jnDto.adreasa = adresaService.getAdresa(jnDto.adresaID).Result;
			jnDto.ovlascenoLice = ovlascenoLiceService.getOvlascenoLice(jnDto.ovlascenoLiceID).Result;
			foreach(Guid p in jnDto.parceleID)
			{
				jnDto.parcele.Add(parcelaService.getParcela(p).Result);
			}
			foreach(Guid k in jnDto.prijavljeniKupciID)
			{
				jnDto.prijavljeniKupci.Add(kupacService.getKupci(k).Result);
			}

			return Ok(jnDto);
		}

		[HttpDelete("{javnoNadmetanjeId}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult deleteJavnoNadmetanje(Guid javnoNadmetanjeId)
		{
			try
			{
				Entities.JavnoNadmetanje jn = javnoNadmetanjeRepository.getJavnoNadmetanjeByID(javnoNadmetanjeId);

				if (jn == null)
				{
					return NotFound();
				}

				javnoNadmetanjeRepository.deleteJavnoNadmetanje(javnoNadmetanjeId);
				javnoNadmetanjeRepository.saveChanges();
				return NoContent();
			}
			catch (Exception ex)
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
		public ActionResult<JavnoNadmetanjeConformationDto> putJavnoNadmetanje(JavnoNadmetanjeUpdateDto jnDto)
		{
			try
			{
				Entities.JavnoNadmetanje oldJn = javnoNadmetanjeRepository.getJavnoNadmetanjeByID(jnDto.javnoNadmetanjeID);

				if (oldJn == null)
				{
					return NotFound();
				}

				Entities.JavnoNadmetanje javnoNadmetanje = mapper.Map<Entities.JavnoNadmetanje>(jnDto);
				mapper.Map(javnoNadmetanje, oldJn);
				javnoNadmetanjeRepository.saveChanges();
				return Ok(mapper.Map<JavnoNadmetanjeConformationDto>(oldJn));
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
		public ActionResult<JavnoNadmetanjeConformationDto> postJavnoNadmetnanje([FromBody] JavnoNadmetanjeCreationDto javnoNadmetanjeDto)
		{
			try
			{
				Entities.JavnoNadmetanje javnoNadmetanje = mapper.Map<Entities.JavnoNadmetanje>(javnoNadmetanjeDto);
				javnoNadmetanjeRepository.postJavnoNadmetanje(javnoNadmetanje);
				javnoNadmetanjeRepository.saveChanges();
				return Created("uri", mapper.Map<JavnoNadmetanjeConformationDto>(javnoNadmetanje));

			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Post error");
			}
		}
	}
}

