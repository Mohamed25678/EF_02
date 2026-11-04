using EF_02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_02
{
    internal class EventHubDBContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Organizer> Organizers { get; set; } = null!;
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Attende> Attendees { get; set; } = null!;
        public DbSet<Badge> Badges { get; set; } = null!;

        ModelBuilder modelBuilder = new ModelBuilder();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Badge>(B =>
            {
                B.HasKey(B => B.Id);
                B.HasIndex(B => B.BadgeNumber).IsUnique();
                B.Property(B => B.IssuedAt).IsRequired();
                B.Property(B => B.Tier).HasConversion<string>().IsRequired();


                B.HasOne(B => B.Attendee).WithOne(A => A.Badge).HasForeignKey<Badge>(B => B.AttendeId).OnDelete(DeleteBehavior.Restrict);




            });




        }
    }
}
    

