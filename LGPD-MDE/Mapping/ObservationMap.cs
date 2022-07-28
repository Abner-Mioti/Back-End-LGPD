using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class ObservationMap : IEntityTypeConfiguration<Observation>
    {
        public void Configure(EntityTypeBuilder<Observation> builder)
        {
            builder.ToTable("OBSERVATION");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Observations)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("OBSERVATIONS");

        }

    }
}
