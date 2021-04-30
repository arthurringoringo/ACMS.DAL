using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ACMS.DAL.Models.Configurations
{
    public class ClassReportConfig : IEntityTypeConfiguration<ClassReport>
    {
        public void Configure(EntityTypeBuilder<ClassReport> builder)
        {
            builder.ToTable("ClassReport");

            builder.Property(e => e.ClassReportId).HasMaxLength(250);



        }


    }

}
