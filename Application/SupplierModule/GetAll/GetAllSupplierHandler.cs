using Application.SupplierModule.Dtos;
using Application.SupplierModule.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.GetAll
{
    public sealed class GetAllSupplierHandler
    {
        private readonly ISupplierRepository _repo;

        public GetAllSupplierHandler(ISupplierRepository repo)
        {
            _repo = repo;
        }

        public async Task<GetAllProveedoresResponse> Handle(GetAllSuppliersQuery query, CancellationToken ct = default)
        {
            var proveedores = await _repo.GetAllAsync(ct);

            var dtos = proveedores
                .OrderBy(p => p.Name)
                .Select(p => new SupplierDto(
                    p.Id,

                    p.Name,
                    p.Telephone,
                    p.Email,

                    p.CheckSetDeadlineId,
                    p.IncludesVATDefault,
                    p.FreightIncludedDefault,

                    p.UsualFreightCost,
                    p.PaymentTermsText,
                    p.Observations,

                    p.CreatedAt,
                    p.UpdatedAt
                ))
                .ToList();

            return new GetAllProveedoresResponse(dtos);
        }
    }
}
