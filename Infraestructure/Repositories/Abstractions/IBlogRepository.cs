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

        Task<Blog?> EditBlog(int id, Blog entity);
    }
}
