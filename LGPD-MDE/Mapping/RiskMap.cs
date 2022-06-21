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
    public class RiskMap : IEntityTypeConfiguration<Risk>
    {
        public void Configure(EntityTypeBuilder<Risk> builder)
        {
            builder.ToTable("RISK");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Risks)
            .HasColumnType("VARCHAR")
            .HasColumnName("RISKS").HasMaxLength(150);

        }

    }
}
