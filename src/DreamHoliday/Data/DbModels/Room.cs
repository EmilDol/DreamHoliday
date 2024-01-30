using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public List<Reservation> Reservations { get; set; } = null!;
    }
}
