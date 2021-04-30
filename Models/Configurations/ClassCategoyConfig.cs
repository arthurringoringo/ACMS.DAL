using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACMS.DAL.Models.Configurations
{
    public class ClassCategoyConfig : IEntityTypeConfiguration<ClassCategory>
    {
        public void Configure(EntityTypeBuilder<ClassCategory> builder)
        {
            builder.HasKey(e => e.CategoryId);

            builder.ToTable("ClassCategory");

            builder.Property(e => e.CategoryId).HasMaxLength(250);

            builder.Property(e => e.DiscountedFee).HasColumnType("smallmoney");

            builder.Property(e => e.IncomeAiu)
                .HasColumnType("smallmoney")
                .HasColumnName("IncomeAIU");

            builder.Property(e => e.IncomeInstructor).HasColumnType("smallmoney");

            builder.Property(e => e.TotalTutionFee).HasColumnType("smallmoney");




        }


    }

}
