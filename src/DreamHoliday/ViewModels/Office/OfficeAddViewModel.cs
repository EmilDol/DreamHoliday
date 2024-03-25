using System.ComponentModel.DataAnnotations;

using DreamHoliday.ViewModels.City;

namespace DreamHoliday.ViewModels.Office
{
    public class OfficeAddViewModel
    {
        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [Display(Name = "Номер на офис")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [Display(Name = "Град")]
        public Guid CityId { get; set; }

        public List<CityViewModel>? Cities { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(2, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(50, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [Display(Name = "Адрес")]
        public string Address { get; set; } = null!;
    }
}
