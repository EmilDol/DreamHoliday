using DreamHoliday.ViewModels.Office;

namespace DreamHoliday.Services.Contracts
{
    public interface IOfficeService
    {
        Task<List<OfficeViewModel>> GetAll();
    }
}
