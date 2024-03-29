﻿using System.ComponentModel.DataAnnotations;

using DreamHoliday.ViewModels.City;

namespace DreamHoliday.ViewModels.Auth
{
    public class ClientRegisterViewModel
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
        [Display(Name = "Дата на раждане")]
        public DateTime BirthDate { get; set; }

        [Required]
        [MinLength(9)]
        [MaxLength(03)]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MinLength(5)]
        [MaxLength(320)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Имейл адрес")]
        public string Email { get; set; } = null!;

        [Required]
        [Display(Name = "Град")]
        public Guid CityId { get; set; }

        public List<CityViewModel> Cities { get; set; } = null!;

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

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "Бащино име")]
        public string MiddleName { get; set; } = null!;
    }
}
