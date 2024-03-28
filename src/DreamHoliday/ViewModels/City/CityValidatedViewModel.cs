using System.ComponentModel.DataAnnotations;

using DreamHoliday.ViewModels.Country;

namespace DreamHoliday.ViewModels.City
{
    public class CityValidatedViewModel
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(2, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(100, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [Display(Name = "Име")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [Display(Name = "Държава")]
        public Guid CountryId { get; set; }

        public List<CountryViewModel>? Countries { get; set; }
    }
}
