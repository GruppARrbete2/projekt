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

        public async  Task<List<Output>> FindEntriesByDoor(string name)
        {
         var list = await  _templateDBContext.Outputs.Where(output => output.DörrBenämning == name).ToListAsync();

            return list;           
        }
        
        public async Task<List<Output>> FindEntriesByTag(string name)
        {
            var list = await _templateDBContext.Outputs.Where(output => output.Tag == name).ToListAsync();

            return list;
        }

        public async Task<List<Output>> FindEntriesByCode(string name)
        {
            var list = await _templateDBContext.Outputs.Where(output => output.Code == name).ToListAsync();

            return list;
        }
    }
}
