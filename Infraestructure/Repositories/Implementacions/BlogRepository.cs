using Domain;
using Infraestructure.Context;
using Infraestructure.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories.Implementacions
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogRepository(ApplicationDbContext context)
        {
            _context = context;
        }
      
        public async Task<Blog?>Buscar(int id)
        => await _context.Blogs.FindAsync(id);

        public async Task<Blog?> EditBlog(int id, Blog entity)
        {    
            var model = await _context.Blogs.FindAsync(id);
            if (model != null)
            {
                model.Comentario = entity.Comentario;
                _context.Blogs.Update(model);
                await _context.SaveChangesAsync();
            }
            return model;
        }

        public async Task<IList<Blog>>ListaBlogs()
           => await _context.Blogs.OrderByDescending(e => e.Id).ToListAsync();
    }
}
