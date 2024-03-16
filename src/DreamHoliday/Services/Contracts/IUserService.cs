using DreamHoliday.ViewModels.Auth;

namespace DreamHoliday.Services.Contracts
{
    public interface IUserService
    {
        Task<List<AgentUnapprovedViewModel>> GetAgentUnapprovedAgents();
    }
}
