using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Srinjay_Recipe.Models;

namespace Srinjay_Recipe.Data
{
    public class Srinjay_RecipeContext : DbContext
    {
        public Srinjay_RecipeContext (DbContextOptions<Srinjay_RecipeContext> options)
            : base(options)
        {
        }

        public DbSet<Srinjay_Recipe.Models.Recipe> Recipe { get; set; } = default!;
    }
}
