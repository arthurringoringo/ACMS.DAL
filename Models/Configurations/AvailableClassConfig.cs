using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACMS.DAL.Models.Configurations
{
    public class AvailableClassConfig : IEntityTypeConfiguration<AvailableClass>
    {
        public void Configure(EntityTypeBuilder<AvailableClass> builder)
        {
            
                builder.HasKey(e => e.ClassId);

                builder.Property(e => e.ClassId).HasMaxLength(250);

                builder.Property(e => e.ClassName).HasMaxLength(250);

                builder.Property(e => e.TeacherId)
                    .IsRequired()
                    .HasMaxLength(250);

                builder.HasOne(d => d.Teacher)
                    .WithMany(p => p.AvailableClasses)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_AvailableClasses_Teacher");
          


        }
    
    
    }

}
