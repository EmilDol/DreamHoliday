using DreamHoliday.Data;
using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.City;
using DreamHoliday.ViewModels.Enums;

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

        public async Task<List<CityViewModel>> GetAll(OrderDirection order, string name, Guid? countryId, bool destinationOnly)
        {
            var cities = await context.Cities
                .Include(c => c.Country)
                .Where(c => c.Name.Contains(string.IsNullOrEmpty(name) ? c.Name : name))
                .Where(c => c.CountryId == (countryId ?? c.CountryId))
                .Where(c => c.IsDestination == (destinationOnly ? true : c.IsDestination))
                .OrderBy(c => c.Name)
                .Select(c => new CityViewModel
                {
                    Id = c.Id,
                    IsDestination = c.IsDestination,
                    Name = c.Name,
                    Country = c.Country.Name
                })
                .ToListAsync();

            if (order == OrderDirection.Descending)
            {
                cities = cities.OrderByDescending(c => c.Name).ToList();
            }

            return cities;
        }
    }
}
