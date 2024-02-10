using DreamHoliday.Data.DbModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DreamHoliday.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            var countries = new List<Country>();

            var country = new Country
            {
                Id = new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"),
                Name = "България",
                PhoneCode = "+359"
            };

            countries.Add(country);

            country = new Country
            {
                Id = new Guid("86811293-072c-459c-953e-02a9a3597d11"),
                Name = "Румъния",
                PhoneCode = "+40"
            };

            countries.Add(country);

            country = new Country
            {
                Id = new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"),
                Name = "Гърция",
                PhoneCode = "+30"
            };

            countries.Add(country);

            builder.HasData(countries);
        }
    }
}
