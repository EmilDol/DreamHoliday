using DreamHoliday.Data;
using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.Office;

using Microsoft.EntityFrameworkCore;

namespace DreamHoliday.Services
{
    public class OfficeService : IOfficeService
    {
        private readonly ApplicationDbContext context;

        public OfficeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<OfficeViewModel>> GetAll()
        {
            var offices = await context.Offices
                .Select(o => new OfficeViewModel
                {
                    Id = o.Id,
                    Number = o.Number,
                })
                .ToListAsync();

            return offices;
        }
    }
}
