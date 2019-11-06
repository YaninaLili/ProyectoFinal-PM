using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_PM.Models
{
    public class VidaSaludableContext : IdentityDbContext
    {
        public VidaSaludableContext(DbContextOptions<VidaSaludableContext> o) : base(o){

        }
    }
}