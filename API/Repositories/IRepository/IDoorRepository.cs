using API.Models;

namespace API.Repositories.IRepository
{
    public interface IDoorRepository
    {
        Task<List<Output>> FindEntriesByDoor(string name);

        Task<List<Output>> FindEntriesByCode(string name);

        Task<List<Output>> FindEntriesByTag(string name);

        Task<List<Output>> FindEntriesByDörrBenämning(string name);

        Task<List<Output>> FindEntriesByTenant(string name);

    }
}
