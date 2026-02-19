using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.Dtos
{
    public sealed record SupplierDto
    (
        Guid Id,

        string Name,
        string? Telephone,
        string? Email,

        int CheckSetDeadlineId,
        bool IncludesVATDefault,
        bool FreightIncludedDefault,

        decimal? UsualFreightCost,
        string? PaymentTermsText,
        string? Observations,

        DateTime CreatedAtUtc,
        DateTime? UpdatedAtUtc
    );
}
