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
    public class PersonaMaps : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("PERSONA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Nombre).HasColumnName("NOMBRE");
            builder.Property(x => x.Apellido).HasColumnName("APELLIDO");
            builder.Property(x => x.IdPerfil).HasColumnName("ID_PERFIL");
            builder.Property(x => x.FechaRegistro).HasColumnName("FECHA_REGISTRO");
            builder.Property(x => x.Estado).HasColumnName("ESTADO");

            builder.HasOne(x => x.Perfil).WithMany(x => x.Personas).HasForeignKey(x => x.IdPerfil);

        }
    }
}
