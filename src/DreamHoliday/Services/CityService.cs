using DreamHoliday.Data;
using DreamHoliday.Data.DbModels;
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

        public async Task<bool> Add(CityValidatedViewModel model)
        {
            var city = new City
            {
                IsDestination = false,
                Name = model.Name,
                CountryId = model.CountryId
            };

            try
            {
                await context.Cities.AddAsync(city);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            var city = await context.Cities
                .Include(c => c.Clients)
                .Include(c => c.Offices)
                .Include(c => c.Hotels)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (city == null || (city.Clients.Any() || city.Offices.Any() || city.Hotels.Any()) || city.IsDestination)
            {
                return false;
            }

            context.Cities.Remove(city);
            await context.SaveChangesAsync();

            return true;
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

        public async Task<CityValidatedViewModel> GetById(Guid id)
        {
            var city = await context.Cities
                .Select(c => new CityValidatedViewModel
                {
                    Name = c.Name,
                    CountryId = c.CountryId,
                    Id = c.Id
                })
                .FirstOrDefaultAsync(c => c.Id == id);

            return city;
        }

        public async Task<bool> Update(CityValidatedViewModel model)
        {
            var city = await context.Cities.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (city == null)
            {
                return false;
            }

            city.Name = model.Name;
            city.CountryId = model.CountryId;
            await context.SaveChangesAsync();

            return true;
        }
    }
}
