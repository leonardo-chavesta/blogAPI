﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Blog
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Comentario { get; set; }
        public DateTime? FechaRegistro { get; set; } = DateTime.Now;
        public int Estado { get; set; } = 1;
    }
}
