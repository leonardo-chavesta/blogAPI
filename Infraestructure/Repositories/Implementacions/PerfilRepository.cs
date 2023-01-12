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
    public class PerfilRepository  : IPerfilRepository
    {
        private readonly ApplicationDbContext _context;

        public PerfilRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Perfil?> Buscar(int id)
         => await _context.Perfiles.FindAsync(id);

        public async Task<IList<Perfil>> ListaPerfil()
         => await _context.Perfiles.Where(x => x.Estado == 1).OrderByDescending(e => e.Id).ToListAsync();
    }
}
