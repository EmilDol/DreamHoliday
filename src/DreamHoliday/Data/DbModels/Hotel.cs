using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamHoliday.Data.DbModels
{
    public class Hotel
    {
        public Hotel()
        {
            Rooms = new List<Room>();
            Ratings = new List<Rating>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string Address { get; set; } = null!;

        [Required]
        [MinLength(9)]
        [MaxLength(14)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(City))]
        public Guid CityId { get; set; }
        public City City { get; set; } = null!;

        public List<Room> Rooms { get; set; } = null!;

        public List<Rating> Ratings { get; set; }
    }
}
