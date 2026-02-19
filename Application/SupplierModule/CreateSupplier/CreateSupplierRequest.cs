using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SupplierModule.CreateSupplier
{
    public sealed class CreateSupplierRequest
    {
        public required string Name { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }

        public int CheckSetDeadlineId { get; set; } = 1;  //Plazo cheque
        public bool IncludesVATDefault { get; set; } //Incluye IVA bool
        public bool FreightIncludedDefault { get; set; } //Flete incluido bool

        public decimal? UsualFreightCost { get; set; } //Costo de flete usual
        public string? PaymentTermsText { get; set; } //Texto de condiciones de pago
        public string? Observations { get; set; }
    }
}
