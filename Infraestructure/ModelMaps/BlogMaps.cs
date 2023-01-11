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
    public class BlogMaps : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("BLOG");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).HasColumnName("TITULO");
            builder.Property(x => x.Descripcion).HasColumnName("DESCRIPCION");
            builder.Property(x => x.Estado).HasColumnName("ESTADO");
            builder.Property(x => x.Comentario).HasColumnName("COMENTARIO");
            builder.Property(x => x.FechaRegistro).HasColumnName("FECHA_REGISTRO");
        }
    }
}
