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

            var user = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = " ADMIN@MAIL.COM",
                FirstName = "Petar",
                LastName = "Petrov",
                PhoneNumber = "0888888888"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "admin123!");

            users.Add(user);

            builder.HasData(users);
        }
    }
}
