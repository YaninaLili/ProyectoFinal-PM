using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_PM.Models
{
    public class VidaSaludableContext : IdentityDbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public VidaSaludableContext(DbContextOptions<VidaSaludableContext> o) : base(o)
        {

        }
    }
}