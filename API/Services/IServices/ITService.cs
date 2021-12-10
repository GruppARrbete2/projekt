using API.Models;

namespace API.Services.IServices
{
    public interface ITService
    {
        Task<List<Template>> GetAll();
    }
}
