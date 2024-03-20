using DreamHoliday.Data;
using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.Enums;
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

        public async Task<List<OfficeBasicViewModel>> GetAll()
        {
            var offices = await context.Offices
                .OrderBy(x => x.Number)
                .Select(o => new OfficeBasicViewModel
                {
                    Id = o.Id,
                    Number = o.Number,
                })
                .ToListAsync();

            return offices;
        }

        public async Task<List<OfficeCardViewModel>> GetAll(OrderDirection order, int agents, int clients, Guid? cityId)
        {
            var offices = await context.Offices
                .Include(o => o.Agents)
                .ThenInclude(a => a.Reservations)
                .Include(o => o.Agents)
                .ThenInclude(a => a.User)
                .Where(o => o.Agents.Count <= (agents <= 0 ? int.MaxValue : agents))
                .Where(o => o.Agents.Sum(a => a.Reservations.Count) <= (clients <= 0 ? int.MaxValue : clients))
                .Where(o => o.CityId == (cityId ?? o.CityId))
                .OrderBy(a => a.Number)
                .Select(o => new OfficeCardViewModel
                {
                    Id=o.Id,
                    Number=o.Number,
                    PhoneNumber = o.PhoneNumber,
                    Address = o.Address,
                    Agents = o.Agents.Select(a => $"{a.User.FirstName} {a.User.LastName}").ToList()
                })
                .ToListAsync();

            if (order == OrderDirection.Descending)
            {
                offices = offices.OrderByDescending(x => x.Number).ToList();
            }

            return offices;
        }
    }
}
