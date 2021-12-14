using API.Models;

namespace API.Services.IServices
{
    public interface IDoorService
    {
        Task<List<Output>> FindEntriesByDoor(string name);
    }
}
