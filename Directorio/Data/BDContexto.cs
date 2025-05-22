using Microsoft.EntityFrameworkCore;

namespace Directorio.Data
{
    public class BDContexto : DbContext
    {
        public BDContexto(DbContextOptions<BDContexto> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; } = null!;
        public DbSet<Clasificacion> Clasificaciones { get; set; } = null!;
        public DbSet<Habito> Habitos { get; set; } = null!;
    }
}
