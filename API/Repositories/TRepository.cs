using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class TRepository : ITRepository
    {

        private readonly TemplateDBContext _templateDBContext;
        public TRepository(TemplateDBContext templateDBContext)
        {
            _templateDBContext = templateDBContext;
        }

   
       public async Task<List<Template>> GetAll()
        {
            return await _templateDBContext.Templates.ToListAsync();
        }
    }
}
