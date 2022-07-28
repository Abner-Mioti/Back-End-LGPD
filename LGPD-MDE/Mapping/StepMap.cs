

using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class StepMap : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder.ToTable("STEP");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Steps)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("STEPS");

            builder.Property(x => x.Value)
           .HasColumnType("INT")
           .HasColumnName("VALUE").IsRequired(true);

            builder.Property(x => x.CloseDate)
           .HasColumnType("DATE")
           .HasColumnName("CLOSE_DATE");

            builder.Property(x => x.EndDate)
           .HasColumnType("DATE")
           .HasColumnName("END_DATE");

            builder.Property(x => x.Itens)
           .HasColumnType("INT")
           .HasColumnName("ITENS").IsRequired(true);

            builder.Property(x => x.Active)
           .HasColumnType("BIT")
           .HasColumnName("ACTIVE");

        }

    }
}
