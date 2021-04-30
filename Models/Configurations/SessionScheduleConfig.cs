using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACMS.DAL.Models.Configurations
{
    public class SessionScheduledConfig : IEntityTypeConfiguration<SessionSchedule>
    {
        public void Configure(EntityTypeBuilder<SessionSchedule> builder)
        {
            builder.HasKey(e => e.ScheduleId);

            builder.ToTable("SessionSchedule");

            builder.Property(e => e.ScheduleId).HasMaxLength(250);

            builder.Property(e => e.ClassId)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.Day).HasMaxLength(50);

            builder.Property(e => e.StudentId)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.TeacherId)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.Class)
                .WithMany(p => p.SessionSchedules)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SessionSchedule_AvailableClasses");

            builder.HasOne(d => d.Student)
                .WithMany(p => p.SessionSchedules)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_SessionSchedule_Student");

            builder.HasOne(d => d.Teacher)
                .WithMany(p => p.SessionSchedules)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_SessionSchedule_Teacher")
                .OnDelete(DeleteBehavior.NoAction);
        }


    }

}
