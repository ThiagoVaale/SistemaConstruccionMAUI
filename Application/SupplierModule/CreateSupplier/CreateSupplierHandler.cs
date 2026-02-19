using Application.SupplierModule.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.CreateSupplier
{
    public sealed class CreateSupplierHandler
    {
        private readonly ISupplierRepository _repo;

        public CreateSupplierHandler(ISupplierRepository repo)
        {
            _repo = repo;
        }

        public async Task<CreateSupplierResponse> Handle(CreateSupplierRequest request, CancellationToken ct = default)
        {
            var name = (request.Name ?? "").Trim();
            if (string.IsNullOrWhiteSpace(name))
                return new CreateSupplierResponse(false, null, "El nombre es obligatorio.");

            var exists = await _repo.ExistsNameAsync(name, excludeId: null, ct);
            if (exists)
                return new CreateSupplierResponse(false, null, "Ya existe un proveedor con ese nombre.");

            Supplier supplier;

            try
            {
                supplier = new Supplier(
                    name,
                    request.Telephone,
                    request.Email,
                    request.CheckSetDeadlineId,
                    request.IncludesVATDefault,
                    request.FreightIncludedDefault,
                    request.UsualFreightCost,
                    request.PaymentTermsText,
                    request.Observations
                );
            }
            catch (ArgumentException ex)
            {
                return new CreateSupplierResponse(false, null, ex.Message);
            }

            await _repo.AddAsync(supplier, ct);
            await _repo.SaveChangesAsync(ct);

            return new CreateSupplierResponse(true, supplier.Id, null);
        }
    }
}
