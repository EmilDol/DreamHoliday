using DreamHoliday.ViewModels.City;

namespace DreamHoliday.Services.Contracts
{
    public interface ICityService
    {
        Task<List<CityViewModel>> GetAll();
    }
}
