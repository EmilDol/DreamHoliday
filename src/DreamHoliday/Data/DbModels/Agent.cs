using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamHoliday.Data.DbModels
{
    public class Agent
    {
        public Agent()
        {
            Reservations = new List<Reservation>();
        }

        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Office))]
        public Guid OfficeId { get; set; }
        public Office Office { get; set; } = null!;

        public List<Reservation> Reservations { get; set; } = null!;
    }
}
