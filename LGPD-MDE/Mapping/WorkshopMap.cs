using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class WorkshopMap : IEntityTypeConfiguration<Workshop>
    {
        public void Configure(EntityTypeBuilder<Workshop> builder)
        {
            builder.ToTable("WORKSHOP");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.MeetingLink)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("MEETING_LINK");

            builder.Property(x => x.Date)
            .HasColumnType("DATETIME")
            .HasColumnName("DATE");

        }


    }
}
