using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Coments
{
    public class ComentsFormDto
    {
        public int IdUsuario { get; set; }
        public int IdBlog { get; set; }
        public string? Comentario { get; set; }
    }
}
