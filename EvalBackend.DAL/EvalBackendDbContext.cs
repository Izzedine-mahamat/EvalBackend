using EvalBackend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalBackend.DAL
{
    public class EvalBackendDbContext : DbContext
    {
        public EvalBackendDbContext(DbContextOptions options) : base(options)
        {
        }

        public EvalBackendDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("EvalBackend");
            }
        }

        public DbSet<Users> Users { get; set; }
    }
}

