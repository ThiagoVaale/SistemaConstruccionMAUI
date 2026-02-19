using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.CreateSupplier
{
    public sealed record CreateSupplierResponse
    (
        bool Success,
        Guid? Id,
        string? Error
    );
}
