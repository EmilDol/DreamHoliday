using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamHoliday.Data.DbModels
{
    public class City
    {
        public City()
        {
            Hotels = new List<Hotel>();
            Clients = new List<Client>();
            Offices = new List<Office>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public bool IsDestination { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = null!;

        public List<Hotel> Hotels { get; set; } = null!;

        public List<Client> Clients { get; set; } = null!;

        public List<Office> Offices { get; set; } = null!;
    }
}
