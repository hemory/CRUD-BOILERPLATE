using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheRoundTableApplication.Models;

namespace TheRoundTableApplication.Models
{
    public class TheRoundTableApplicationContext : DbContext
    {
        public TheRoundTableApplicationContext (DbContextOptions<TheRoundTableApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<TheRoundTableApplication.Models.Course> Course { get; set; }

        public DbSet<TheRoundTableApplication.Models.Student> Student { get; set; }
    }
}
