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
    public class FieldMap : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.ToTable("FIELD");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Fields)
            .HasColumnType("VARCHAR")
            .HasColumnName("FIELDS").HasMaxLength(150);

        }

    }
}
