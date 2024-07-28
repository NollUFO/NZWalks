using NZWalks.Repositories;
using NZWalks.Models.Domain;

// THIS IS ONLY FOR DEMO PURPOSES
namespace NZWalks.Repositories
{
    public class InMemoryRegionRepository: IRegionRepository
    {
        public async Task<List<Region>> GetAllAsync()
        {
            return new List<Region>()
            {
                new Region()
                {
                    Id = Guid.NewGuid(),
                    Code = "OR",
                    Name = "Oliver's Region name"
                }
            };
        }
    }
}
