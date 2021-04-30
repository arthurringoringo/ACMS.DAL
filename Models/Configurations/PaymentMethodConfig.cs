using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACMS.DAL.Models.Configurations
{
    public class PaymentMethodConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethod");

            builder.Property(e => e.PaymentMethodId).HasMaxLength(250);

            builder.Property(e => e.MethodName).HasMaxLength(250);

        }


    }

}
