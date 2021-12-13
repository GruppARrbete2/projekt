using API.Models;

namespace API.Repositories.IRepository
{
    public interface IDoorRepository
    {
       Task<Door> FindEntriesByDoor(int id);
    }
}
