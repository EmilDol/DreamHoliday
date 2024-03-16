using DreamHoliday.Data.DbModels;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DreamHoliday.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            //Admin
            var user = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Петър",
                LastName = "Петров",
                PhoneNumber = "0888888888",
                EmailConfirmed = true
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "admin123!");

            users.Add(user);

            //Agents
            user = new ApplicationUser()
            {
                Id = "aa85aebf-98df-4aac-9b93-578664d43b8a",
                UserName = "agent1",
                NormalizedUserName = "AGENT1",
                Email = "agent1@mail.com",
                NormalizedEmail = "AGENT1@MAIL.COM",
                FirstName = "Иван",
                LastName = "Иванов",
                PhoneNumber = "0888888888",
                EmailConfirmed = true
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "agent1123!");

            users.Add(user);
            
            user = new ApplicationUser()
            {
                Id = "a94432c6-6f4c-4e54-b3fd-ade9649ea26a",
                UserName = "agent2",
                NormalizedUserName = "AGENT2",
                Email = "agent2@mail.com",
                NormalizedEmail = "AGENT2@MAIL.COM",
                FirstName = "Ангел",
                LastName = "Ангелов",
                PhoneNumber = "0888888888",
                EmailConfirmed = false
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "agent2123!");

            users.Add(user);
            
            //Clients
            user = new ApplicationUser()
            {
                Id = "b72a2e9e-5e12-46a4-a463-4fb3689c95a6",
                UserName = "client1",
                NormalizedUserName = "CLIENT1",
                Email = "client1@mail.com",
                NormalizedEmail = "CLIENT1@MAIL.COM",
                FirstName = "Борис",
                LastName = "Борисов",
                PhoneNumber = "0888888888",
                EmailConfirmed = true
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "client1123!");

            users.Add(user);
            
            user = new ApplicationUser()
            {
                Id = "57323aaa-f541-49d5-acff-f387440cd033",
                UserName = "client2",
                NormalizedUserName = "CLIENT2",
                Email = "client2@mail.com",
                NormalizedEmail = "CLIENT2@MAIL.COM",
                FirstName = "Георги",
                LastName = "Георгиев",
                PhoneNumber = "0888888888",
                EmailConfirmed = true
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "client2123!");

            users.Add(user);

            builder.HasData(users);
        }
    }
}
