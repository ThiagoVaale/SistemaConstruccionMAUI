using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.Interfaces
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAllAsync(CancellationToken ct = default);
        Task<Supplier?> GetByIdAsync(Guid id, CancellationToken ct = default);

        Task AddAsync(Supplier proveedor, CancellationToken ct = default);

        Task<bool> ExistsNameAsync(string nombre, Guid? excludeId = null, CancellationToken ct = default);

        Task SaveChangesAsync(CancellationToken ct = default);
    }
}
   
