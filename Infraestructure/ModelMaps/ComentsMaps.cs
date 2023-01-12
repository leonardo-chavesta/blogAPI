using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.ModelMaps
{
    public class ComentsMaps : IEntityTypeConfiguration<Coment>
    {
        public void Configure(EntityTypeBuilder<Coment> builder)
        {
            builder.ToTable("COMENTARIO_BLOG");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Comentario).HasColumnName("COMENTARIO");
            builder.Property(x => x.IdUsuario).HasColumnName("ID_USUARIO");
            builder.Property(x => x.IdBlog).HasColumnName("ID_BLOG");
            builder.Property(x => x.FechaRegistro).HasColumnName("FECHA_REGISTRO");
            builder.Property(x => x.Estado).HasColumnName("ESTADO");
        }
    }
}
