using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Design;
using bshbbackend.Models;

namespace bshbbackend
{
    public class BshbDbContext: DbContext
    {
        public BshbDbContext(DbContextOptions<BshbDbContext> options) : base(options)
        {

        }
        public DbSet<Chairman> Chairmen { get; set; }
        public DbSet<ContactList> ContactLists { get; set; }
        public DbSet<CurrentTenders> CurrentTender { get; set; }
        public DbSet<EmployeeList> EmployeeLists { get; set; }
        public DbSet<MDList> MDLists { get; set; }
        public DbSet<MDMessage> MDMessages { get; set; }
        public DbSet<OfficerList> OfficerLists { get; set; }
        public DbSet<PhotoGallery> PhotoGallerys { get; set; }
        public DbSet<HeaderLogo> HeaderLogos { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<SubNotice> SubNotices { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chairman>()
                .Property(e => e.Photo)
                .HasColumnType("VARBINARY(MAX)");

            modelBuilder.Entity<MDList>()
              .Property(e => e.Photo)
              .HasColumnType("VARBINARY(MAX)");

            modelBuilder.Entity<OfficerList>()
             .Property(e => e.Photo)
             .HasColumnType("VARBINARY(MAX)");

            modelBuilder.Entity<PhotoGallery>()
            .Property(e => e.Photo)
            .HasColumnType("VARBINARY(MAX)");
        }
    }
}
