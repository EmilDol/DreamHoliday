using DreamHoliday.Data.DbModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DreamHoliday.Data.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            var clients = new List<Client>();
            var client = new Client
            {
                Id = new Guid("82819ff0-3697-4e2f-af83-2db578a23813"),
                BirthDate = new DateTime(2005, 12, 19),
                CityId = new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"),
                MiddleName = "Петков",
                UserId = "b72a2e9e-5e12-46a4-a463-4fb3689c95a6"
            };

            clients.Add(client);

            client = new Client
            {
                Id = new Guid("d999134f-b7dc-4fc1-ad10-b2035d9fff41"),
                BirthDate = new DateTime(1989, 4, 1),
                CityId = new Guid("38605449-8d0a-48d4-8870-cf6b703ada63"),
                MiddleName = "Николаев",
                UserId = "57323aaa-f541-49d5-acff-f387440cd033"
            };

            clients.Add(client);
            builder.HasData(clients);
        }
    }
}
