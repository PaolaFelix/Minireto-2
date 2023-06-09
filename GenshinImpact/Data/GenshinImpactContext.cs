using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenshinImpact.Models;

namespace GenshinImpact.Data
{
    public class GenshinImpactContext : DbContext
    {
        public GenshinImpactContext (DbContextOptions<GenshinImpactContext> options)
            : base(options)
        {
        }

        public DbSet<GenshinImpact.Models.Character> Character { get; set; } = default!;
    }
}
