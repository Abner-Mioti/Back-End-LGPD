using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class QuestionCategoryMap : IEntityTypeConfiguration<QuestionCategory>
    {
        public void Configure(EntityTypeBuilder<QuestionCategory> builder)
        {
            builder.ToTable("QUESTION_CATEGORY");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Category)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("CATEGORY");

        }


    }
}
