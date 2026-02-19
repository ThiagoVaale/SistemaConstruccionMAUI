using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.DeleteSupplier
{
    public sealed record DeleteSupplierResponse
        (bool Success, string? Error);
}
