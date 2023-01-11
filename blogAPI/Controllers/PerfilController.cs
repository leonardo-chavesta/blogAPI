using Application.Dtos.Perfiles;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : Controller
    {
        private readonly IPerfilService _perfilService;
        public PerfilController(IPerfilService perfilService)
        {
            _perfilService = perfilService;
        }

        [HttpGet]
        public async Task<IEnumerable<PerfilDto>> Get()
            => await _perfilService.ListaPerfil();

        [HttpPost("Obtener/{id}")]
        public async Task<Results<NotFound, Ok<PerfilDto>>>Get(int id)
        {
            var response = await _perfilService.Buscar(id);
            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }

    }
}
