using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)  
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(x => x.Telephone)
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .HasMaxLength(120);

            builder.Property(x => x.CheckSetDeadlineId)
                .IsRequired();

            builder.Property(x => x.UsualFreightCost)
                .HasPrecision(18, 2);

            builder.Property(x => x.PaymentTermsText)
                .HasMaxLength(1000);

            builder.Property(x => x.Observations)
                .HasMaxLength(1000);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdatedAt);
        }
    }
}
