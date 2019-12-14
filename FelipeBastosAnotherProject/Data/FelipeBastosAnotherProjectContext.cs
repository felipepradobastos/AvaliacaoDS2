using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FelipeBastosAnotherProject.Models;

namespace FelipeBastosAnotherProject.Models
{
    public class FelipeBastosAnotherProjectContext : DbContext
    {
        public FelipeBastosAnotherProjectContext (DbContextOptions<FelipeBastosAnotherProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FelipeBastosAnotherProject.Models.Jogador> Jogador { get; set; }

        public DbSet<FelipeBastosAnotherProject.Models.Placar> Placar { get; set; }
    }
}
