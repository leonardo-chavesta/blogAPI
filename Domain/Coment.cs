using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Coment
    {
        public int Id { get; set; }
        public string? Comentario { get; set; }
        public int IdUsuario { get; set; }
        public int IdBlog { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public int Estado { get; set; } = 1;

    }
}
