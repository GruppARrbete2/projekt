using API.Models;
using API.Services.IServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [EnableCors("CORSPolicy")]
    [Route("[controller]")]
    public class DoorController : ControllerBase
    {
      
            private readonly IDoorService _doorService;

            public DoorController(IDoorService doorService)
            {
            _doorService = doorService;
            }
         

            [HttpGet("FindEntriesByDoor")]
            public async Task<Door> FindEntriesByDoor(int ID)
            {
                return await _doorService.FindEntriesByDoor(ID);
            }
        }
    }
}
