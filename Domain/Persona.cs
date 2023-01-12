using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Estado { get; set; } = 1;
        public DateTime? FechaRegistro { get; set; } = DateTime.Now;
        public int? IdPerfil { get; set; }
        public virtual Perfil? Perfil { get; set; }
    }
}
