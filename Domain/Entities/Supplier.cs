using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }

        public int CheckSetDeadlineId { get; set; }  //Plazo cheque
        public bool IncludesVATDefault { get; set; } //Incluye IVA bool
        public bool FreightIncludedDefault { get; set; } //Flete incluido bool

        public decimal? UsualFreightCost { get; set; } //Costo de flete usual
        public string? PaymentTermsText { get; set; } //Texto de condiciones de pago
        public string? Observations { get; set; }

        private Supplier() { }

        public Supplier(
        string name,
        string? telephone,
        string? email,
        int checkSetDeadlineId,
        bool includesVATDefault,
        bool freightIncludedDefault,
        decimal? usualFreightCost,
        string? paymentTermsText,
        string? observations)
        {
            SetName(name);

            Telephone = telephone;
            Email = email;
            CheckSetDeadlineId = checkSetDeadlineId;
            IncludesVATDefault = includesVATDefault;
            FreightIncludedDefault = freightIncludedDefault;
            UsualFreightCost = usualFreightCost;
            PaymentTermsText = paymentTermsText;
            Observations = observations;
        }

        public void Update(
            string name,
            string? telephone,
            string? email,
            int checkSetDeadlineId,
            bool includesVATDefault,
            bool freightIncludedDefault,
            decimal? usualFreightCost,
            string? paymentTermsText,
            string? observations)
        {
            SetName(name);

            Telephone = telephone;
            Email = email;
            CheckSetDeadlineId = checkSetDeadlineId;
            IncludesVATDefault = includesVATDefault;
            FreightIncludedDefault = freightIncludedDefault;
            UsualFreightCost = usualFreightCost;
            PaymentTermsText = paymentTermsText;
            Observations = observations;

            MarkUpdated();
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre es obligatorio.");

            Name = name.Trim();
        }
    }
}
