using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACMS.DAL.Models.Configurations
{
    public class PaidSessionConfig : IEntityTypeConfiguration<PaidSession>
    {
        public void Configure(EntityTypeBuilder<PaidSession> builder)
        {
            builder.Property(e => e.PaidSessionId).HasMaxLength(250);

            builder.Property(e => e.RegistredClassId)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.DatePaid).HasColumnType("datetime");

            builder.Property(e => e.PaymentsMonth).HasMaxLength(100);

            builder.HasOne(d => d.RegistredClass)
                .WithMany(p => p.PaidSession)
                .HasForeignKey(d => d.RegistredClassId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PaidSessions_RegistredClass");

        }


    }

}
