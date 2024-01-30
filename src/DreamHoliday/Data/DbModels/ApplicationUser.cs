using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;

namespace DreamHoliday.Data.DbModels
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        public Client? Client { get; set; }
        public Agent? Agent { get; set; }
    }
}
