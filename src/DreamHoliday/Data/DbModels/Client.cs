using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamHoliday.Data.DbModels
{
    public class Client
    {
        public Client()
        {
            Reservations = new List<Reservation>();
            Ratings = new List<Rating>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string MiddleName { get; set; } = null!;

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [ForeignKey(nameof(City))]
        public Guid CityId { get; set; }
        public City City { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        public List<Reservation> Reservations { get; set; } = null!;

        public List<Rating> Ratings { get; set; }
    }
}
