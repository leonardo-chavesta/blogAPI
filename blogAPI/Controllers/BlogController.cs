using Application.Dtos.Blogs;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
         
        [HttpGet]
        public async Task<IEnumerable<BlogDto>> Get()
            => await _blogService.ListaBlogs();

        [HttpGet("Obtener/{id}")]
        public async Task<Results<NotFound, Ok<BlogDto>>>Get(int id)
        {
            var response = await _blogService.Buscar(id);
            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }
        [HttpPut("Comentar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BlogDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results< NotFound,Ok<BlogDto>>> Put(int id , [FromBody] BlogFormDto request)
        {
            var response = await _blogService.EditBlog(id, request);

            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }


        [HttpPost("Crear")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BlogDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results<BadRequest, Ok<BlogDto>>> Post([FromBody] BlogFormDto request)
        {
            var response = await _blogService.CrearBlog(request);
            if (response == null) return TypedResults.BadRequest();

            return TypedResults.Ok(response);
        }
        [HttpDelete("Eliminar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BlogDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<Results<NotFound, Ok<BlogDto>>> Delete(int id)
        {
            var response = await _blogService.Eliminar(id);
            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }

    }
}
