using DreamHoliday.ViewModels.Enums;
using DreamHoliday.ViewModels.Office;

namespace DreamHoliday.Services.Contracts
{
    public interface IOfficeService
    {
        Task<List<OfficeBasicViewModel>> GetAll();

        Task<List<OfficeCardViewModel>> GetAll(OrderDirection order, int agents, int clients, Guid? cityId);

        Task<bool> Add(OfficeAddViewModel model);

        Task<OfficeUpdateViewModel> GetById(Guid id);

        Task<bool> Update(OfficeUpdateViewModel model);

        Task Delete(Guid id);
    }
}
