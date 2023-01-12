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
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ApplicationDbContext _context;
        public PersonaRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<Persona?> BusCarPersona(int id)
            => await _context.Personas.FindAsync(id);

        public async Task<Persona> CrearPersona(Persona entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
            
        }

        public async Task<Persona?> EditPersona(int id, Persona entity)
        {
            var model = await _context.Personas.FindAsync(id);
            if(model != null) 
            {
                model.Nombre= entity.Nombre;
                model.Apellido= entity.Apellido;
                model.IdPerfil = entity.IdPerfil;
                _context.Personas.Update(model);
                await _context.SaveChangesAsync();
            }
            return model;
        }

        public async Task<Persona?> EliminarPersona(int id)
        {
            var model = await _context.Personas.FindAsync(id);
            if (model != null)
            {
                model.Estado = (model.Estado == 0) ? 1 : 0;

                _context.Personas.Update(model);
                await _context.SaveChangesAsync();
            }
            return model;
        }

        public async Task<IList<Persona>> ListarPersona()
         => await _context.Personas.Where(x=>x.Estado == 1).OrderByDescending(x=>x.Id).ToListAsync();
    } 
}
