using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Areas.Identity.Data;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }
        public DbSet<Aspirante> aspirantes { get; set; }
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Estudiante> estudiantes { get; set; }
        public DbSet<Grado> grados { get; set; }
        public DbSet<Matricula> matriculas { get; set; }
        public DbSet<ReservaCupo> reservaCupos { get; set; }
        public DbSet<Sede> sedes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
