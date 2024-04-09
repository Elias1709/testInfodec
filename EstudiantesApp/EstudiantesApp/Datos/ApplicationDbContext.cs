using EstudiantesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudiantesApp.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)        
        {
                 
        }

        public DbSet<Estudiante> Estudiante { get; set; }
    }
}
