using System.ComponentModel.DataAnnotations;

namespace DreamHoliday.ViewModels.Office
{
    public class OfficeUpdateViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(2, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(50, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [Display(Name = "Адрес")]
        public string Address { get; set; } = null!;

        public int Number { get; set; }

        public string City { get; set; } = null!;
    }
}
