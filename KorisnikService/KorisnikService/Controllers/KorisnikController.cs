using System;
using AutoMapper;
using KorisnikService.DtoModels;
using KorisnikService.Entities;
using KorisnikService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KorisnikService.Controllers 
{
	[ApiController]
    [Route("api/korisnici")]
    [Produces("application/json", "application/xml")]
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikRepository korisnikRepository;
        private readonly IMapper mapper;
        public KorisnikController(IKorisnikRepository korisnikRepository, IMapper mapper)
		{
            this.korisnikRepository = korisnikRepository;
            this.mapper = mapper;
		}

        /// <summary>
        /// Vraca sve korisnike.
        /// </summary>
        /// <returns> Lista korisnika</returns>
        /// <response code="200">Lista korisnika</response>
        /// <response code="404">Nije pronadjen ni jedan korisnik</response>
        [HttpGet]
        [HttpHead]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<KorisnikDto>> getAllKorisnici()
        {
            List<Korisnik> korisnici = korisnikRepository.getAllKorisnici();

            if (korisnici == null || korisnici.Count == 0)
            {
                return NoContent();
            }

            return Ok(mapper.Map<List<KorisnikDto>>(korisnici));
        }

        /// <summary>
        /// Vraca samojednog korisnika.
        /// </summary>
        /// <returns> Jedan korisnik</returns>
        /// <response code="200">Korisni je uspesno pronadjen</response>
        /// <response code="404">Korisnik nije pronadjen</response>

        [HttpGet("{korisnikId}")]
        [HttpHead]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<KorisnikDto> getKorisnikById(Guid korisnikId)
        {
            Korisnik k = korisnikRepository.getKorisnikById(korisnikId);
            if (k == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<KorisnikDto>(k));
        }

        /// <summary>
        /// Brise korisnika.
        /// </summary>
        /// <response code="204">Korisnik je uspesno obrisan</response>
        /// <response code="404">Nema korisnika sa prosledjenim id-jem</response>
        /// <response code="500">Greska prilikom brisanja korisnika</response>
        [HttpDelete("{korisnikId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult deleteKorisnik(Guid korisnikId)
        {
            try
            {
                Korisnik k = korisnikRepository.getKorisnikById(korisnikId);
                if (k == null)
                {
                    return NotFound();
                }

                korisnikRepository.deleteKorisnik(korisnikId);
                korisnikRepository.SaveChanges();
                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Delete error");
            }

        }

        /// <summary>
        /// Kreiranje korisnika.
        /// </summary>
        /// <returns>Krreirani korisnik</returns>
        /// <response code="201">Korisnik je uspesno kreiran</response>
        /// <response code="500">Greska prilikom kreiranja korisnika</response>

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [Produces("application/json")]
        public ActionResult<KorisnikDto> postKorisnik([FromBody] KorisnikCreateDto korisnik)
        {
            try
            {
                Korisnik K = mapper.Map<Korisnik>(korisnik);
                Korisnik kor = korisnikRepository.postKorisnik(K);
                korisnikRepository.SaveChanges();
                return Created("uri", mapper.Map<KorisnikDto>(kor));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong");
            }


        }

        /// <summary>
        /// Izmena korisnika.
        /// </summary>
        /// <response code="200">Korisnik je uspesno izmenjen</response>
        /// <response code="404">Nema korisnika sa prosledjenim id-jem</response>
        /// <response code="500">Greska prilikom izmene korisnika</response>

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult putKorisnik(KorisnikUpdateDto korisnik)
        {
            try
            {
                Korisnik Korisnik = mapper.Map<Korisnik>(korisnik);
                Korisnik k = korisnikRepository.getKorisnikById(Korisnik.korisnikId);

                if (k == null)
                {
                    return NotFound();
                }


                KorisnikDto korisnikDto = mapper.Map<KorisnikDto>(korisnik);
                mapper.Map(korisnikDto, k);
                return Ok(mapper.Map<KorisnikDto>(k));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Put error");
            }
        }
    }
}

