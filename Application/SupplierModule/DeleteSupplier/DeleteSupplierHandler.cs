using Application.SupplierModule.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.DeleteSupplier
{
    public sealed class DeleteSupplierHandler
    {
        private readonly ISupplierRepository _repo;

        public DeleteSupplierHandler(ISupplierRepository repo)
        {
            _repo = repo;
        }

        public async Task<DeleteSupplierResponse> Handle(DeleteSupplierRequest request, CancellationToken ct = default)
        {
            Supplier? proveedor = await _repo.GetByIdAsync(request.Id, ct);
            if (proveedor is null)
                return new DeleteSupplierResponse(false, "Proveedor no encontrado.");

            proveedor.SoftDelete();
            await _repo.SaveChangesAsync(ct);

            return new DeleteSupplierResponse(true, null);
        }
    }
}
