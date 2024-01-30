using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamHoliday.Data.DbModels
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public DateTime CancellingDate { get; set; }

        [Required]
        public DateTime ArrivalDate { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        [Required]
        public bool LateDeparture { get; set; }

        [Required]
        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Room Room { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Agent))]
        public Guid AgentId { get; set; }
        public Agent Agent { get; set; } = null!;
    }
}
