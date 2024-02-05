using System.ComponentModel.DataAnnotations;

using DreamHoliday.ViewModels.Office;

namespace DreamHoliday.ViewModels.Auth
{
    public class AgentRegisterViewModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "Собствено име")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = null!;

        [Required]
        [MinLength(5)]
        [MaxLength(320)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Имейл адрес")]
        public string Email { get; set; } = null!;

        [Required]
        [Display(Name = "Номер на офис")]
        public Guid OfficeId { get; set; }

        public List<OfficeViewModel> Offices { get; set; } = null!;

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; } = null!;

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Display(Name = "Потвърди парола")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
