using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Personas
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Estado { get; set; } = 1;
        public DateTime? FechaRegistro { get; set; }
        public int? IdPerfil { get; set; }
        public virtual PersonaDto Perfil { get; set; }
    }
}
