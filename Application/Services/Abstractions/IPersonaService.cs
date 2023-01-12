using Application.Dtos.Perfiles;
using Application.Dtos.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Abstractions
{
    public interface IPersonaService
    {
        Task<IList<PersonaDto>> ListarPersona();
        Task<PersonaDto> BuscarPersona(int id);
        Task<PersonaDto> CrearPersona(PersonaFormDto entity);
        Task<PersonaDto?> EliminarPersona(int id);
    }
}
