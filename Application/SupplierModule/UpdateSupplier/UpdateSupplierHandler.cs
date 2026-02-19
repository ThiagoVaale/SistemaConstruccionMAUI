using Application.SupplierModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.UpdateSupplier
{
    public sealed class UpdateSupplierHandler
    {
        private readonly ISupplierRepository _repo;

        public UpdateSupplierHandler(ISupplierRepository repo)
        {
            _repo = repo;
        }

        public async Task<UpdateSupplierResponse> Handle(UpdateSupplierRequest request, CancellationToken ct = default)
        {
            var proveedor = await _repo.GetByIdAsync(request.Id, ct);
            if (proveedor is null)
                return new UpdateSupplierResponse(false, "Proveedor no encontrado.");

            string nombre = request.Name?.Trim() ?? "";
            bool exists = await _repo.ExistsNameAsync(nombre, excludeId: request.Id, ct);
            if (exists)
                return new UpdateSupplierResponse(false, "Ya existe un proveedor con ese nombre.");

            try
            {
                proveedor.Update(
                    nombre,
                    request.Telephone,
                    request.Email,
                    request.CheckSetDeadlineId,
                    request.IncludesVATDefault,
                    request.FreightIncludedDefault,
                    request.UsualFreightCost,
                    request.PaymentTermsText,
                    request.Observations
                );

                await _repo.SaveChangesAsync(ct);
                return new UpdateSupplierResponse(true, null);
            }
            catch (ArgumentException ex)
            {
                return new UpdateSupplierResponse(false, ex.Message);
            }
        }
    }
}
