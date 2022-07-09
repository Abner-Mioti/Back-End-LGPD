using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class CompanyCategoryMap : IEntityTypeConfiguration<CompanyCategory>
    {
        public void Configure(EntityTypeBuilder<CompanyCategory> builder)
        {
            builder.ToTable("COMPANY_CATEGORY");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Category)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("CATEGORY");

        }


    }
}
