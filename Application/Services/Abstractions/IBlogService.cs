using Application.Dtos.Blogs;
using Application.Dtos.Perfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Abstractions
{
    public interface IBlogService
    {
        Task<BlogDto?> Buscar(int id);
        Task<IList<BlogDto>> ListaBlogs();
        Task<BlogDto?> EditBlog(int id, BlogsComentFormDto entity);

        Task<BlogDto> CrearBlog(BlogFormDto entity);
        Task<BlogDto?> Eliminar(int id);
    }
}
