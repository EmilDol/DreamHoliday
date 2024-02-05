using DreamHoliday.Data;
using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.City;

using Microsoft.EntityFrameworkCore;

namespace DreamHoliday.Services
{
    public class CityService : ICityService
    {
        private readonly ApplicationDbContext context;

        public CityService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<CityViewModel>> GetAll()
        {
            var cities = await context.Cities
                .Include(c => c.Country)
                .Select(c => new CityViewModel
                {
                    Country = c.Country.Name,
                    Name = c.Name,
                    Id = c.Id
                })
                .ToListAsync();

            return cities;
        }
    }
}
