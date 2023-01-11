using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories.Abstractions
{
    public interface IBlogRepository
    {
        Task<IList<Blog>> ListaBlogs();
        Task<Blog?> Buscar(int id);
        Task<Blog> CrearBlog(Blog entity);
        Task<Blog?> EditBlog(int id, Blog entity);
        Task<Blog?> Eliminar(int id);
    }
}
