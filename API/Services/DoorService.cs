using API.Models;
using API.Repositories;
using API.Repositories.IRepository;
using API.Services.IServices;

namespace API.Services
{
    public class DoorService : IDoorService
    {

        private readonly IDoorRepository _doorRepository;

        public DoorService(IDoorRepository doorRepository)
        {
            _doorRepository = doorRepository;
        }



        public Task<List<Output>> FindEntriesByDoor(string name)
        {
           return  _doorRepository.FindEntriesByDoor(name);
        }


        public Task<List<Output>> FindEntriesByCode(string name)
        {
            return _doorRepository.FindEntriesByCode(name);
        }
    }
}
