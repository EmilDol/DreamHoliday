namespace DreamHoliday.ViewModels.City
{
    public class CityViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Country { get; set; } = null!;

        public bool? IsDestination { get; set; }
    }
}
