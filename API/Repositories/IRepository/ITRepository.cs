
using API.Models;
using System.Drawing;

namespace API.Repositories
{
    public interface ITRepository
{
         Task<List<Template>> GetAll();
    }
}
