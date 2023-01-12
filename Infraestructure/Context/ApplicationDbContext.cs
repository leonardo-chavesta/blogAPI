using Domain;
using Infraestructure.ModelMaps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DBConnection"));
        }

        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Blog> Blogs { get; set; }  
        public DbSet<Coment> Coments { get; set; }
        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PerfilMaps());
            modelBuilder.ApplyConfiguration(new BlogMaps());
            modelBuilder.ApplyConfiguration(new ComentsMaps());
            modelBuilder.ApplyConfiguration(new PersonaMaps());

        }
    }
}
