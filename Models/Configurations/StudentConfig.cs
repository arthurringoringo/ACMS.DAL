using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACMS.DAL.Models.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");

            builder.Property(e => e.StudentId).HasMaxLength(250);

            builder.Property(e => e.Address).HasMaxLength(450);

            builder.Property(e => e.BirthDate).HasColumnType("date");

            builder.Property(e => e.FirstName).HasMaxLength(250);

            builder.Property(e => e.HomeNumber).HasMaxLength(50);

            builder.Property(e => e.LastName).HasMaxLength(250);

            builder.Property(e => e.ParentGuardianName).HasMaxLength(250);

            builder.Property(e => e.SchoolName).HasMaxLength(250);

            builder.Property(e => e.Sex).HasMaxLength(7);

            builder.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(250);
            builder.HasOne(e => e.User)
            .WithOne(p => p.Student)
            .HasForeignKey<Student>(e => e.UserId);
        }


    }

}
