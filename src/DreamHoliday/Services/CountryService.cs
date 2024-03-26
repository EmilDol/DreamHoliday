using DreamHoliday.Data;
using DreamHoliday.Data.DbModels;
using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels;
using DreamHoliday.ViewModels.Country;
using DreamHoliday.ViewModels.Enums;

using Microsoft.EntityFrameworkCore;

namespace DreamHoliday.Services
{
    public class CountryService : ICountryService
    {
        private readonly ApplicationDbContext context;

        public CountryService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Add(string name, string phoneCode)
        {
            if (await context.Countries.AnyAsync(c => c.Name == name))
            {
                return false;
            }

            await context.Countries.AddAsync(new Country
            {
                Name = name,
                PhoneCode = phoneCode
            });
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            var country = await context.Countries
                .Include(c => c.Cities)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (country == null || country.Cities.Any())
            {
                return false;
            }
            context.Countries.Remove(country);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<CountryViewModel>> GetAll(OrderDirection order, string name)
        {
            var countries = await context.Countries
                .Where(c => c.Name.Contains((string.IsNullOrEmpty(name) ? c.Name : name)))
                .Select(c => new CountryViewModel
                {
                    Name = c.Name,
                    Id = c.Id,
                    PhoneCode = c.PhoneCode
                })
                .OrderBy(c => c.Name)
                .ToListAsync();

            if (order == OrderDirection.Descending)
            {
                countries = countries.OrderByDescending(c => c.Name).ToList();
            }

            return countries;
        }

        public async Task<CountryViewModel> GetById(Guid id)
        {
            var country = await context.Countries
                .Select(c => new CountryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    PhoneCode = c.PhoneCode
                })
                .FirstOrDefaultAsync(c => c.Id == id);

            return country;
        }

        public async Task<bool> Update(CountryViewModel model)
        {
            var country = await context.Countries.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (country == null)
            {
                return false;
            }

            country.Name = model.Name;
            country.PhoneCode = model.PhoneCode;

            await context.SaveChangesAsync();
            return true;
        }
    }
}
