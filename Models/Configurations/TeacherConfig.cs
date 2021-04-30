using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACMS.DAL.Models.Configurations
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher");

            builder.Property(e => e.TeacherId).HasMaxLength(250);

            builder.Property(e => e.Address).HasMaxLength(450);

            builder.Property(e => e.BirthDate).HasColumnType("date");

            builder.Property(e => e.FirstName).HasMaxLength(250);

            builder.Property(e => e.LastName).HasMaxLength(250);

            builder.Property(e => e.HomeNumber).HasMaxLength(250);

            builder.Property(e => e.Sex).HasMaxLength(7);

            builder.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(250);
            builder.HasOne(e => e.User)
            .WithOne(p => p.Teacher)
            .HasForeignKey<Teacher>(e => e.UserId);
        }


    }

}
