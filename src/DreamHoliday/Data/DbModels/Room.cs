using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DreamHoliday.Data.DbModels.Enums;

namespace DreamHoliday.Data.DbModels
{
    public class Room
    {
        public Room()
        {
            Reservations = new List<Reservation>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public decimal AdultPrice { get; set; }

        [Required]
        public decimal ChildBelow12Price { get; set; }

        [Required]
        public decimal ChildBelow7Price { get; set; }

        [Required]
        [ForeignKey(nameof(Hotel))]
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;

        [Required]
        public RoomType Type { get; set; }

        [Required]
        public RoomCategory Category { get; set; }

        [Required]
        public int SingleBeds { get; set; }
        
        [Required]
        public int DoubleBeds { get; set; }

        public List<Reservation> Reservations { get; set; } = null!;
    }
}
