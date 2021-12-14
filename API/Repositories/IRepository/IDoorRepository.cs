using API.Models;

namespace API.Repositories.IRepository
{
    public interface IDoorRepository
    {
        Task<List<Output>> FindEntriesByDoor(string name);
    }
}
