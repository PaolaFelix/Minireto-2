using Microsoft.EntityFrameworkCore;

namespace GenshinImpact.Data
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) 
            : base(options) 
        {
        }
        public DbSet<GenshinImpact.Models.Character>? Characters { get; set; }
    }
}
