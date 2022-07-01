using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class EnterpriseCategoryMap : IEntityTypeConfiguration<EnterpriseCategory>
    {
        public void Configure(EntityTypeBuilder<EnterpriseCategory> builder)
        {
            builder.ToTable("ENTERPRISE_CATEGORY");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Category)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("CATEGORY");

        }


    }
}
