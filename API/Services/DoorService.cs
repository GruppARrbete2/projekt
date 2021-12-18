using API.Models;
using API.Repositories;
using API.Repositories.IRepository;
using API.Services.IServices;
using System.Xml.Linq;

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

        public Task<List<Output>> FindEntriesByTag(string name)
        {
            return _doorRepository.FindEntriesByTag(name);
        }

        public Task<List<Output>> FindEntriesByDörrBenämning(string name)
        {
            return _doorRepository.FindEntriesByDörrBenämning(name);
        }

        public Task<List<Output>> FindEntriesByTenant(string name)
        {
            return _doorRepository.FindEntriesByTenant(name);

        }
        public Task<List<Tenant>> ListTenantsAt(string name)
        {
            return _doorRepository.ListTentatsAt(name);

        }

        public Task<Output> CreateData(string dörrBenämning, string code, string tag, string person)
{

            return _doorRepository.CreateData(dörrBenämning, code, tag, person);
        }

       public Task<List<Output>> ListTwentyOutputTables()
        {
            return _doorRepository.ListTwentyOutputTables();
        }


      
    }
}
