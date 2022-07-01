using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class AreaMap : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("AREA");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Areas)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("AREAS");

        }

    }
}
