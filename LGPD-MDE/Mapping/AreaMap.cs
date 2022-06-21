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
    public class AreaMap : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("AREA");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Areas)
            .HasColumnType("VARCHAR")
            .HasColumnName("AREAS").HasMaxLength(150);

        }

    }
}
