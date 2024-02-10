using DreamHoliday.Data.DbModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DreamHoliday.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            var cities = new List<City>();
            var city = new City
            {
                Id = new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"),
                CountryId = new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"),
                Name = "Велико Търново"
            };
            cities.Add(city);

            city = new City
            {
                Id = new Guid("698f99e7-a344-44a0-957c-a98ce4eccbaf"),
                CountryId = new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"),
                Name = "Варна"
            };
            cities.Add(city);

            city = new City
            {
                Id = new Guid("73fdbbb6-d252-4bc2-998c-fae2ed240555"),
                CountryId = new Guid("86811293-072c-459c-953e-02a9a3597d11"),
                Name = "Букурещ"
            };
            cities.Add(city);

            city = new City
            {
                Id = new Guid("38605449-8d0a-48d4-8870-cf6b703ada63"),
                CountryId = new Guid("86811293-072c-459c-953e-02a9a3597d11"),
                Name = "Тимишоара"
            };
            cities.Add(city);

            city = new City
            {
                Id = new Guid("63d7784d-6714-42ed-896a-73346ba66044"),
                CountryId = new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"),
                Name = "Атина"
            };
            cities.Add(city);

            city = new City
            {
                Id = new Guid("dc2c8910-e342-4a07-9197-0dbde7061905"),
                CountryId = new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"),
                Name = "Солун"
            };
            cities.Add(city);

            builder.HasData(cities);
        }
    }
}
