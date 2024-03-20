using DreamHoliday.ViewModels.Enums;
using DreamHoliday.ViewModels.Office;

namespace DreamHoliday.Services.Contracts
{
    public interface IOfficeService
    {
        Task<List<OfficeBasicViewModel>> GetAll();
        Task<List<OfficeCardViewModel>> GetAll(OrderDirection order, int agents, int clients, Guid? cityId);
    }
}
