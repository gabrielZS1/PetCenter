using Microsoft.EntityFrameworkCore;
using PetCenterPTCC.Models;

namespace PetCenterPTCC.Data
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}