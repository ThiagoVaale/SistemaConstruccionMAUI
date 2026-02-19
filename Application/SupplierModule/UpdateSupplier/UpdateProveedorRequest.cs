using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.UpdateSupplier
{
    public sealed record UpdateSupplierRequest(
        Guid Id,

        string Name,
        string? Telephone,
        string? Email,

        int CheckSetDeadlineId,
        bool IncludesVATDefault,
        bool FreightIncludedDefault,

        decimal? UsualFreightCost,
        string? PaymentTermsText,
        string? Observations
);
}
