using EF_02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_02.Configrutions
{
    internal class EventConfigrution:IEntityTypeConfiguration<Event>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate);
            builder.Property(x => x.MaxAttendees).IsRequired();

            builder.HasOne(e => e.Organizer).WithMany(o => o.Events).HasForeignKey(e => e.OrganizerId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
