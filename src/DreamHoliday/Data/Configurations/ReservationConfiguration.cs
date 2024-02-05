using DreamHoliday.Data.DbModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DreamHoliday.Data.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder
                .HasOne(r => r.Client)
                .WithMany(h => h.Reservations)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(r => r.Room)
                .WithMany(h => h.Reservations)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
