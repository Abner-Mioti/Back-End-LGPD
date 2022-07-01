using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class ImpactMap : IEntityTypeConfiguration<Impact>
    {
        public void Configure(EntityTypeBuilder<Impact> builder)
        {
            builder.ToTable("IMPACT");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Impacts)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("IMPACTS");

        }

    }
}
