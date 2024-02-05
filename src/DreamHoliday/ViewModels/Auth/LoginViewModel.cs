using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DreamHoliday.ViewModels.Auth
{
    public class LoginViewModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(320)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Имейл адрес")]
        public string Email { get; set; } = null!;

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; } = null!;
    }
}
