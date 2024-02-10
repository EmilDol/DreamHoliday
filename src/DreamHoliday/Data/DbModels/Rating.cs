using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamHoliday.Data.DbModels
{
    public class Rating
    {
        [Required]
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Hotel))]
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;

        [Required]
        [Range(0, 00)]
        public int Stars { get; set; }
    }
}
