using DreamHoliday.Data.DbModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DreamHoliday.Data.Configurations
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder
                .HasKey(k => new { k.ClientId, k.HotelId });

            builder
                .HasOne(r => r.Hotel)
                .WithMany(h => h.Ratings)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
