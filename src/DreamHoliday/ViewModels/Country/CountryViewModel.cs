using System.ComponentModel.DataAnnotations;

namespace DreamHoliday.ViewModels.Country
{
    public class CountryViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        public string PhoneCode { get; set; } = null!;
    }
}
