using DreamHoliday.ViewModels;
using DreamHoliday.ViewModels.Country;
using DreamHoliday.ViewModels.Enums;

namespace DreamHoliday.Services.Contracts
{
    public interface ICountryService
    {
        Task<List<CountryViewModel>> GetAll(OrderDirection order, string name);

        Task<bool> Add(string name, string phoneCode);

        Task<bool> Delete(Guid id);
        Task<CountryViewModel> GetById(Guid id);
        Task<bool> Update(CountryViewModel model);
    }
}
