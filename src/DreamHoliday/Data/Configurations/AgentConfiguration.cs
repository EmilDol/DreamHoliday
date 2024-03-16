using DreamHoliday.Data.DbModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DreamHoliday.Data.Configurations
{
    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            var agents = new List<Agent>();
            var agent = new Agent
            {
                Id = new Guid("cf7abbd6-b1b9-4056-88a8-7cc76315e186"),
                OfficeId = new Guid("e0a76579-d653-4ab5-8044-db85da0567df"),
                UserId = "aa85aebf-98df-4aac-9b93-578664d43b8a"
            };

            agents.Add(agent);
            
            agent = new Agent
            {
                Id = new Guid("96df0fcd-5578-4faa-895d-66b1cebed911"),
                OfficeId = new Guid("cf3f3ba8-6459-41c5-8bf5-49992f623c77"),
                UserId = "a94432c6-6f4c-4e54-b3fd-ade9649ea26a"
            };

            agents.Add(agent);
            builder.HasData(agents);
        }
    }
}
