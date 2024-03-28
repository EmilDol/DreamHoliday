﻿using System.ComponentModel.DataAnnotations;

namespace DreamHoliday.ViewModels.Country
{
    public class CountryViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [MinLength(2, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {1} символа.")]
        [MaxLength(50, ErrorMessage = "Полето \"{0}\" трябва да бъде най-много {1} символа.")]
        [Display(Name = "Име")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Полето \"{0}\" е задължително.")]
        [Display(Name = "Телефонен код")]
        public string PhoneCode { get; set; } = null!;
    }
}