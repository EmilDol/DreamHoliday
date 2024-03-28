using DreamHoliday.ViewModels.City;
using DreamHoliday.ViewModels.Enums;

namespace DreamHoliday.Services.Contracts
{
    public interface ICityService
    {
        Task<bool> Delete(Guid id);
        Task<List<CityViewModel>> GetAll();
        Task<List<CityViewModel>> GetAll(OrderDirection order, string name, Guid? countryId, bool destinationOnly);
        Task<bool> Add(CityValidatedViewModel model);
        Task<CityValidatedViewModel> GetById(Guid id);
        Task<bool> Update(CityValidatedViewModel model);
    }
}
