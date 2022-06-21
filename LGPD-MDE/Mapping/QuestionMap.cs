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
    public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("QUESTION");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.AreaId)
            .HasColumnType("INTEGER")
            .HasColumnName("AREA_ID").IsRequired(true);

            builder.Property(x => x.QuestionCategoryId)
            .HasColumnType("INTEGER")
            .HasColumnName("QUESTION_CATEGORY_ID").IsRequired(true);

            builder.Property(x => x.ImpactId)
            .HasColumnType("INTEGER")
            .HasColumnName("IMPACT_ID").IsRequired(true);

            builder.Property(x => x.ProbabilityId)
            .HasColumnType("INTEGER")
            .HasColumnName("PROBABILITY_ID").IsRequired(true);

            builder.Property(x => x.Wording)
            .HasColumnType("VARCHAR")
            .HasColumnName("WORDING").HasMaxLength(100);

            builder.Property(x => x.Reply)
            .HasColumnType("INTEGER")
            .HasColumnName("REPLY");

            builder.Property(x => x.RepliedStatus)
            .HasColumnType("BIT")
            .HasColumnName("REPLIED_STATUS");

            builder.Property(x => x.SuitableStatus)
           .HasColumnType("BIT")
           .HasColumnName("SUITABLE_STATUS");

            builder.Property(x => x.Effect)
           .HasColumnType("VARCHAR")
           .HasColumnName("EFFECT").HasMaxLength(100);

            builder.Property(x => x.Action)
           .HasColumnType("VARCHAR")
           .HasColumnName("ACTION");

             builder.HasOne(y => y.Area)
            .WithMany()
            .HasForeignKey(t => t.AreaId);

            builder.HasOne(y => y.QuestionCategory)
           .WithMany()
           .HasForeignKey(t => t.QuestionCategoryId);

            builder.HasOne(y => y.Impact)
            .WithMany()
            .HasForeignKey(t => t.ImpactId);

            builder.HasOne(y => y.Probability)
           .WithMany()
           .HasForeignKey(t => t.ProbabilityId);
        }

    }
}
