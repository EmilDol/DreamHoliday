using DreamHoliday.Data.DbModels;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DreamHoliday.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Agent> Agents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Rating>()
                .HasKey(k => new { k.ClientId, k.HotelId });

            builder.Entity<Rating>()
                .HasOne(r => r.Hotel)
                .WithMany(h => h.Ratings)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder.Entity<Reservation>()
                .HasOne(r => r.Client)
                .WithMany(h => h.Reservations)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany(h => h.Reservations)
                .OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(builder);
        }
    }
}