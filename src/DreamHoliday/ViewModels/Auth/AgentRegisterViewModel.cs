using System.ComponentModel.DataAnnotations;

using DreamHoliday.ViewModels.Office;

namespace DreamHoliday.ViewModels.Auth
{
    public class AgentRegisterViewModel
    {
        [Required(ErrorMessage = "Полето '{1}' е задължително.")]
        [MinLength(2, ErrorMessage = "Дължината на '{1}' трябва да бъде поне {2} символа.")]
        [MaxLength(30, ErrorMessage = "Дължината на '{1}' не може да надвишава {2} символа.")]
        [Display(Name = "Собствено име")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Полето '{1}' е задължително.")]
        [MinLength(2, ErrorMessage = "Дължината на '{1}' трябва да бъде поне {2} символа.")]
        [MaxLength(50, ErrorMessage = "Дължината на '{1}' не може да надвишава {2} символа.")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Полето '{1}' е задължително.")]
        [MinLength(5, ErrorMessage = "Дължината на '{1}' трябва да бъде поне {2} символа.")]
        [MaxLength(320, ErrorMessage = "Дължината на '{1}' не може да надвишава {2} символа.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Моля, въведете валиден имейл адрес.")]
        [Display(Name = "Имейл адрес")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Полето '{1}' е задължително.")]
        [Display(Name = "Номер на офис")]
        public Guid OfficeId { get; set; }

        public List<OfficeViewModel> Offices { get; set; } = null!;

        [Required(ErrorMessage = "Полето '{1}' е задължително.")]
        [MinLength(8, ErrorMessage = "Дължината на '{1}' трябва да бъде поне {2} символа.")]
        [DataType(DataType.Password, ErrorMessage = "Моля, въведете валидна парола.")]
        [Display(Name = "Парола")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Полето '{1}' е задължително.")]
        [MinLength(8, ErrorMessage = "Дължината на '{1}' трябва да бъде поне {2} символа.")]
        [DataType(DataType.Password, ErrorMessage = "Моля, въведете валидна парола.")]
        [Compare(nameof(Password), ErrorMessage = "Паролите не съвпадат.")]
        [Display(Name = "Потвърди парола")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
