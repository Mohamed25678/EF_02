using EF_02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_02.Configrutions
{
    internal class OrganizerProfileConfigrution:IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BioGraphy).HasMaxLength(500);
            builder.Property(x => x.WebsitUrl).HasMaxLength(200);
            builder.Property(x => x.LogUrl).HasMaxLength(200);


            builder .HasOne(P=>P.Organizer).WithOne(o=>o.Profile).HasForeignKey<OrganizerProfile>(P => P.Id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
