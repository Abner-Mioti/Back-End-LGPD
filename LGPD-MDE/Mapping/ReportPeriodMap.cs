using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class ReportPeriodMap : IEntityTypeConfiguration<ReportPeriod>
    {
        public void Configure(EntityTypeBuilder<ReportPeriod> builder)
        {
            builder.ToTable("REPORT_PERIOD");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Period)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("PERIOD");

        }

    }
}
