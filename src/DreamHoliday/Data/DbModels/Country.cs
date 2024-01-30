using System.ComponentModel.DataAnnotations;

namespace DreamHoliday.Data.DbModels
{
    public class Country
    {
        public Country()
        {
            Cities = new List<City>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        public string PhoneCode { get; set; } = null!;

        public List<City> Cities { get; set; } = null!;
    }
}
