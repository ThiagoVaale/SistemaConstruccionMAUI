using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public sealed class SistemaConstruccionDbContextFactory
    : IDesignTimeDbContextFactory<SistemaConstruccionDbContext>
    {
        public SistemaConstruccionDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SistemaConstruccionDbContext>();

            optionsBuilder.UseSqlite("Data Source=sistema_construccion.dev.db");

            return new SistemaConstruccionDbContext(optionsBuilder.Options);
        }
    }
}
