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
    public class ProbabilityMap : IEntityTypeConfiguration<Probability>
    {
        public void Configure(EntityTypeBuilder<Probability> builder)
        {
            builder.ToTable("PROBABILITY");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Probabilitys)
            .HasColumnType("VARCHAR")
            .HasColumnName("PROBABILITYS").HasMaxLength(150);

        }

    }
}
