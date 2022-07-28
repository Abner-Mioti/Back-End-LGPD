using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("QUESTION");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.AreaId)
            .HasColumnType("INT")
            .HasColumnName("AREA_ID").IsRequired(true);

            builder.Property(x => x.ObservationId)
            .HasColumnType("INT")
            .HasColumnName("OBSERVATION_ID").IsRequired(true);

            builder.Property(x => x.RiskId)
            .HasColumnType("INT")
            .HasColumnName("RISK_ID").IsRequired(true);

            builder.Property(x => x.QuestionCategoryId)
            .HasColumnType("INT")
            .HasColumnName("QUESTION_CATEGORY_ID").IsRequired(true);

            builder.Property(x => x.ImpactId)
            .HasColumnType("INT")
            .HasColumnName("IMPACT_ID").IsRequired(true);

            builder.Property(x => x.ProbabilityId)
            .HasColumnType("INT")
            .HasColumnName("PROBABILITY_ID").IsRequired(true);

            builder.Property(x => x.Wording)
            .HasColumnType("VARCHAR")
            .HasColumnName("WORDING").HasMaxLength(100);

            builder.Property(x => x.Reply)
            .HasColumnType("INT")
            .HasColumnName("REPLY");

            builder.Property(x => x.RepliedStatus)
            .HasColumnType("BIT")
            .HasColumnName("REPLIED_STATUS");

            builder.Property(x => x.SuitableStatus)
           .HasColumnType("BIT")
           .HasColumnName("SUITABLE_STATUS");

            builder.Property(x => x.Effect)
           .HasColumnType("VARCHAR(100)")
           .HasColumnName("EFFECT");

            builder.Property(x => x.Action)
           .HasColumnType("VARCHAR(100)")
           .HasColumnName("ACTION");


        }

    }
}
