using DreamHoliday.Data;
using DreamHoliday.Data.DbModels;
using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.City;
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

        public async Task<bool> Add(OfficeAddViewModel model)
        {
            if (await context.Offices.AnyAsync(o => o.Number == model.Number))
            {
                return false;
            }

            var office = new Office
            {
                Address = model.Address,
                CityId = model.CityId,
                Number = model.Number,
                PhoneNumber = model.PhoneNumber
            };

            await context.Offices.AddAsync(office);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task Delete(Guid id)
        {
            var office = await context.Offices.FirstOrDefaultAsync(o => o.Id == id);
            var agents = await context.Agents
                .Include(a => a.User)
                .Where(o => o.OfficeId == id)
                .ToListAsync();

            context.Agents.RemoveRange(agents);
            foreach (var item in agents)
            {
                context.Users.Remove(item.User);
            }
            context.Offices.Remove(office);
            await context.SaveChangesAsync();
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
            var officesDb = await context.Offices
                .Include(o => o.Agents)
                .ThenInclude(a => a.Reservations)
                .Include(o => o.Agents)
                .ThenInclude(a => a.User)
                .Include(o => o.City)
                .Where(o => o.Agents.Count <= (agents <= 0 ? int.MaxValue : agents))
                .Where(o => o.CityId == (cityId ?? o.CityId))
                .OrderBy(a => a.Number)
                .ToListAsync();

            var offices = officesDb
               .Where(o => o.Agents.Sum(a => a.Reservations.Count) <= (clients <= 0 ? int.MaxValue : clients))
               .Select(o => new OfficeCardViewModel
               {
                   Id = o.Id,
                   Number = o.Number,
                   PhoneNumber = o.PhoneNumber,
                   Address = o.Address,
                   Agents = o.Agents.Select(a => $"{a.User.FirstName} {a.User.LastName}").ToList(),
                   City = new CityViewModel
                   {
                       Id = o.City.Id,
                       Name = o.City.Name,
                   }
               })
               .ToList();

            if (order == OrderDirection.Descending)
            {
                offices = offices.OrderByDescending(x => x.Number).ToList();
            }

            return offices;
        }

        public async Task<OfficeUpdateViewModel> GetById(Guid id)
        {
            var office = await context.Offices
                .Include(o => o.City)
                .Select(o => new OfficeUpdateViewModel
                {
                    Address = o.Address, 
                    Id = o.Id,
                    PhoneNumber = o.PhoneNumber,
                    Number = o.Number,
                    City = o.City.Name
                })
                .FirstOrDefaultAsync(o => o.Id == id);

            return office;
        }

        public async Task<bool> Update(OfficeUpdateViewModel model)
        {
            var office = await context.Offices.FirstOrDefaultAsync(o => o.Id == model.Id);
            if (office == null)
            {
                return false;
            }

            office.Address = model.Address;
            office.PhoneNumber = model.PhoneNumber;

            await context.SaveChangesAsync();

            return true;
        }
    }
}
