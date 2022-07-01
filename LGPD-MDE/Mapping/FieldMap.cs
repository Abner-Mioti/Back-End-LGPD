using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class FieldMap : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.ToTable("FIELD");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Fields)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("FIELDS");

        }

    }
}
