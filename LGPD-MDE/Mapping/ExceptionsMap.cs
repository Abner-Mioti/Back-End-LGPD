using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class ExceptionsMap : IEntityTypeConfiguration<Exceptions>
    {
        public void Configure(EntityTypeBuilder<Exceptions> builder)
        {
            builder.ToTable("EXCEPTIONS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description)
            .HasColumnType("VARCHAR(1100)")
            .HasColumnName("DESCRICAO");

            builder.Property(x => x.Date)
           .HasColumnType("DATETIME")
           .HasColumnName("DATE");

            builder.Property(x => x.Message)
           .HasColumnType("VARCHAR(500)")
           .HasColumnName("MESSAGE");
        }

    }
}
