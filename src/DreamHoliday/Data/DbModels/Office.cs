using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamHoliday.Data.DbModels
{
    public class Office
    {
        public Office()
        {
            Agents = new List<Agent>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        [ForeignKey(nameof(City))]
        public Guid CityId { get; set; }
        public City City { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        public List<Agent> Agents { get; set; } = null!;
    }
}
