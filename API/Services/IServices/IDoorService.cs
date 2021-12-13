using API.Models;

namespace API.Services.IServices
{
    public interface IDoorService
    {
        Task<Door> FindEntriesByDoor(int id);
    }
}
