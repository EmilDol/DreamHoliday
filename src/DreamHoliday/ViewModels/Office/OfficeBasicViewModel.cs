using System.ComponentModel.DataAnnotations;

namespace DreamHoliday.ViewModels.Office
{
    public class OfficeBasicViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public int Number { get; set; }
    }
}
