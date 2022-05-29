using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class BackendContext : DbContext
    {
        public BackendContext(DbContextOptions<BackendContext> options)
            : base(options)
        {
        }

        public DbSet<Backend.Modelo.Estudiante> Estudiante { get; set; }

        public DbSet<Backend.Modelo.Mascota> Mascota { get; set; }
    }
}
