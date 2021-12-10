using API.Models;
using API.Repositories;
using API.Services.IServices;

namespace API.Services
{
    public class TService : ITService
    {
        private readonly ITRepository _tRepository;

        public TService(ITRepository tRepository)
        {
            _tRepository = tRepository;
        }

        public async Task<List<Template>> GetAll()
        {
            var TGetAll = await _tRepository.GetAll();

            return TGetAll;
        }
    }
}
