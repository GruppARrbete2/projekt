using API.Data;
using API.Models;
using API.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class DoorRepository : IDoorRepository
    {
        private readonly TemplateDBContext _templateDBContext;
        public DoorRepository(TemplateDBContext templateDBContext)
        {
            _templateDBContext = templateDBContext;
        }

      

        public async Task<Door> FindEntriesByDoor(int id)
        {
         return  await _templateDBContext.Doors.FirstOrDefaultAsync(door => door.DoorID == id);

        }
    }
}
