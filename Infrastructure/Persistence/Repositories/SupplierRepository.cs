using Application.SupplierModule.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public sealed class SupplierRepository : ISupplierRepository
    {
        private readonly SistemaConstruccionDbContext _db;

        public SupplierRepository(SistemaConstruccionDbContext db)
        {
            _db = db;
        }

        public Task<List<Supplier>> GetAllAsync(CancellationToken ct = default)
        => _db.Suppliers
            .AsNoTracking()
            .OrderBy(x => x.Name)
            .ToListAsync(ct);

        public Task<Supplier?> GetByIdAsync(Guid id, CancellationToken ct = default)
            => _db.Suppliers
                .FirstOrDefaultAsync(x => x.Id == id, ct);

        public async Task AddAsync(Supplier proveedor, CancellationToken ct = default)
        {
            await _db.Suppliers.AddAsync(proveedor, ct);
        }

        public Task<bool> ExistsNameAsync(string nombre, Guid? excludeId = null, CancellationToken ct = default)
        {
            var q = _db.Suppliers.AsQueryable();

            if (excludeId is not null)
                q = q.Where(x => x.Id != excludeId.Value);

            var normalized = (nombre ?? "").Trim();

            return q.AnyAsync(x => x.Name == normalized, ct);
        }

        public Task SaveChangesAsync(CancellationToken ct = default)
            => _db.SaveChangesAsync(ct);
    }
}
