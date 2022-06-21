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
    public class QuestionCategoryMap : IEntityTypeConfiguration<QuestionCategory>
    {
        public void Configure(EntityTypeBuilder<QuestionCategory> builder)
        {
            builder.ToTable("QUESTION_CATEGORY");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Category)
            .HasColumnType("VARCHAR")
            .HasColumnName("CATEGORY").HasMaxLength(100);

        }


    }
}
