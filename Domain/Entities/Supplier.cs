using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public required string Name { get; set; }

        public string? Telephone { get; set; }
        public string? Email { get; set; }

        public int CheckSetDeadlineId { get; set; }  //Plazo cheque

        public bool IncludesVATDefault { get; set; } //Incluye IVA bool
        public bool FreightIncludedDefault { get; set; } //Flete incluido bool

        public decimal? UsualFreightCost { get; set; } //Costo de flete usual

        public string? PaymentTermsText { get; set; } //Texto de condiciones de pago
        public string? Observations { get; set; }
    }
}
