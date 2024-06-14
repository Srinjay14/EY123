using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calling_Backend_Student.Models;

namespace Calling_Backend_Student.Data
{
    public class Calling_Backend_StudentContext : DbContext
    {
        public Calling_Backend_StudentContext (DbContextOptions<Calling_Backend_StudentContext> options)
            : base(options)
        {
        }

        public DbSet<Calling_Backend_Student.Models.Student> Student { get; set; } = default!;
    }
}
