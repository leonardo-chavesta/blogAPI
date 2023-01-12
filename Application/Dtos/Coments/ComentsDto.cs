using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Coments
{
    public class ComentsDto
    {
        public int Id { get; set; }
        public string? Comentario { get; set; }
        public int IdUsuario { get; set; }
        public int IdBlog { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
    }
}
