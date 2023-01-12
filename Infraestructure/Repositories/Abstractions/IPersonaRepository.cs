using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories.Abstractions
{
    public interface IPersonaRepository
    {
        Task<IList<Persona>> ListarPersona();
        Task<Persona?> BusCarPersona(int id);
        Task<Persona> CrearPersona(Persona entity);
        Task<Persona?> EditPersona(int id, Persona entity);
        Task<Persona?> EliminarPersona(int id);

    }
}
