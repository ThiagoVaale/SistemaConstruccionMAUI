using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class SistemaConstruccionDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }

        public SistemaConstruccionDbContext(DbContextOptions<SistemaConstruccionDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
