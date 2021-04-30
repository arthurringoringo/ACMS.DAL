using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
namespace ACMS.DAL.Models.Configurations
{
    public class RegisteredClassConfig : IEntityTypeConfiguration<RegistredClass>
    {
        public void Configure(EntityTypeBuilder<RegistredClass> builder)
        {
            builder.ToTable("RegistredClass");

            builder.Property(e => e.RegistredClassId).HasMaxLength(250);

            builder.Property(e => e.CategoryId)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.ClassId)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.ClassReportId).HasMaxLength(250);

            builder.Property(e => e.DateRegistered).HasColumnType("datetime");

            builder.Property(e => e.AssessmentDate).HasColumnType("datetime");

            builder.Property(e => e.PaymentMethodId)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.StudentId)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.Category)
                .WithMany(p => p.RegistredClasses)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_RegistredClass_ClassCategory");

            builder.HasOne(d => d.Class)
                .WithMany(p => p.RegistredClasses)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_RegistredClass_AvailableClasses");

            builder.HasOne(d => d.ClassReport)
                .WithOne(p => p.RegistredClasses)
                .HasConstraintName("FK_RegistredClass_ClassReport");

            builder.HasOne(d => d.PaymentMethod)
                .WithMany(p => p.RegistredClasses)
                .HasForeignKey(d => d.PaymentMethodId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RegistredClass_PaymentMethod");

            builder.HasOne(d => d.Student)
                .WithMany(p => p.RegistredClasses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

        }


    }

}
