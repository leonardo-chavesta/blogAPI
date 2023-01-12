using Application.Dtos.Perfiles;
using Application.Dtos.Personas;
using Application.Services.Abstractions;
using Application.Services.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : Controller
    {
        private readonly IPersonaService _personaService;
        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonaDto>> Get()
            => await _personaService.ListarPersona();

    }
}
