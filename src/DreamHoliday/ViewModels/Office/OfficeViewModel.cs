using System.ComponentModel.DataAnnotations;

namespace DreamHoliday.ViewModels.Office
{
    public class OfficeViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public int Number { get; set; }
    }
}
