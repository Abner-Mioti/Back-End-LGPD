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
    public class WorkshopMap : IEntityTypeConfiguration<Workshop>
    {
        public void Configure(EntityTypeBuilder<Workshop> builder)
        {
            builder.ToTable("WORKSHOP");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.MeetingLink)
            .HasColumnType("VARCHAR")
            .HasColumnName("MEETING_LINK").HasMaxLength(150);

            builder.Property(x => x.Date)
            .HasColumnType("DATE")
            .HasColumnName("DATE").HasMaxLength(100);

        }


    }
}
