using DreamHoliday.ViewModels.City;

namespace DreamHoliday.ViewModels.Office
{
    public class OfficeCardViewModel
    {
        public Guid Id { get; set; }

        public CityViewModel City { get; set; } = null!;

        public int Number { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public string Address { get; set; } = null!;

        public List<string> Agents { get; set; } = null!;

        public int ClientsCount { get; set; }
    }
}
