using DreamHoliday.Data.DbModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DreamHoliday.Data.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            var offices = new List<Office>();
            var office = new Office
            {
                Id = new Guid("e0a76579-d653-4ab5-8044-db85da0567df"),
                Address = "ул. \"Баба Мота\" № 3",
                Number = 1101,
                PhoneNumber = "0888888888",
                CityId = new Guid("53142745-f66f-4f08-95a1-b8e961c73f05")
            };
            offices.Add(office);

            office = new Office
            {
                Id = new Guid("cf3f3ba8-6459-41c5-8bf5-49992f623c77"),
                Address = "ул. \"Гео Милев\" № 5",
                Number = 1201,
                PhoneNumber = "0888888888",
                CityId = new Guid("698f99e7-a344-44a0-957c-a98ce4eccbaf")
            };
            offices.Add(office);

            builder.HasData(offices);
        }
    }
}