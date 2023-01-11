using Application.Dtos.Perfiles;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : Controller
    {
        /*
         private readonly ITipoEmpleadoService _tipoEmpleadoService;

        public TipoEmpleadoController(ITipoEmpleadoService tipoEmpleadoService)
        {
            _tipoEmpleadoService = tipoEmpleadoService;
        }
         
         */

        private readonly IPerfilService _perfilService;
        public PerfilController(IPerfilService perfilService)
        {
            _perfilService = perfilService;
        }

        [HttpGet]
        public async Task<IEnumerable<PerfilDto>> Get()
            => await _perfilService.ListaPerfil();

    }
}
