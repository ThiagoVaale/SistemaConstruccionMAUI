using Application.SupplierModule.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.GetAll
{
    public sealed record GetAllProveedoresResponse(IReadOnlyList<SupplierDto> Items);
}
