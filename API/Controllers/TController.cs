using API.Models;
using API.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class TController : ControllerBase
    {
        private readonly ITService _tService;

        public TController(ITService tService)
        {
            _tService = tService;
        }
        [HttpGet("All")]
        public async Task<List<Template>> GetAll()
        {
            return await _tService.GetAll();
        }
    }
}
