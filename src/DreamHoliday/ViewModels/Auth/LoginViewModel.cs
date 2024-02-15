using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DreamHoliday.ViewModels.Auth
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Полето '{0}' е задължително.")]
        [MinLength(5, ErrorMessage = "Дължината на '{0}' трябва да бъде поне {0} символа.")]
        [MaxLength(320, ErrorMessage = "Дължината на '{0}' не може да надвишава {0} символа.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Моля, въведете валиден имейл адрес.")]
        [Display(Name = "Имейл адрес")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Полето '{0}' е задължително.")]
        [MinLength(8, ErrorMessage = "Дължината на '{0}' трябва да бъде поне {0} символа.")]
        [DataType(DataType.Password, ErrorMessage = "Моля, въведете валидна парола.")]
        [Display(Name = "Парола")]
        public string Password { get; set; } = null!;
    }
}
