using DreamHoliday.Data;
using DreamHoliday.Services.Contracts;
using DreamHoliday.ViewModels.Auth;

using Microsoft.EntityFrameworkCore;

namespace DreamHoliday.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext context;

        public UserService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<AgentUnapprovedViewModel>> GetAgentUnapprovedAgents()
        {
            var agentRoleId = await context.Roles
                .Where(r => r.Name == "Agent")
                .Select(r => r.Id)
                .FirstAsync();


            var users = await context.Users
                .Where(u => !u.EmailConfirmed)
                
                .Select(u => new AgentUnapprovedViewModel
                {
                    Id = u.Id,
                    Email = u.Email,
                    Name = $"{u.FirstName} {u.LastName}",
                    PhoneNumber = u.PhoneNumber
                })
                .ToListAsync();

            for (int i = 0; i < users.Count; i++)
            {
                if (await context.UserRoles.AnyAsync(ur => ur.UserId == users[i].Id && ur.RoleId == agentRoleId))
                {
                    users[i].OfficeNumber = await context.Agents
                        .Include(a => a.Office)
                        .Where(a => a.UserId == users[i].Id)
                        .Select(a => a.Office.Number)
                        .FirstAsync();
                    continue;
                }
                users.RemoveAt(i);
                i--;
            }

            return users;
        }
    }
}
