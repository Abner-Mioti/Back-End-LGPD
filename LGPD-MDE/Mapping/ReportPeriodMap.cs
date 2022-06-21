using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Mapping
{
    public class ReportPeriodMap : IEntityTypeConfiguration<ReportPeriod>
    {
        public void Configure(EntityTypeBuilder<ReportPeriod> builder)
        {
            builder.ToTable("REPORT_PERIOD");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Period)
            .HasColumnType("VARCHAR")
            .HasColumnName("PERIOD").HasMaxLength(150);

        }

    }
}
