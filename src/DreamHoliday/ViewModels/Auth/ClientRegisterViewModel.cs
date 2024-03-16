using System.ComponentModel.DataAnnotations;

using DreamHoliday.ViewModels.City;

namespace DreamHoliday.ViewModels.Auth
{
    public class ClientRegisterViewModel
    {
        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(2, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(30, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [Display(Name = "Собствено име")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(2, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(50, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [Display(Name = "Дата на раждане")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(9, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(13, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(5, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(320, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Невалиден имейл адрес.")]
        [Display(Name = "Имейл адрес")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [Display(Name = "Град")]
        public Guid CityId { get; set; }

        public List<CityViewModel>? Cities { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(8, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(8, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Паролите не съвпадат.")]
        [Display(Name = "Потвърди парола")]
        public string ConfirmPassword { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(2, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(30, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [Display(Name = "Бащино име")]
        public string MiddleName { get; set; } = null!;
    }

}
