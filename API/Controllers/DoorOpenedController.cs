using API.Models;
using API.Services.IServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [EnableCors("CORSPolicy")]
    [Route("[controller]")]
    public class DoorOpenedController : ControllerBase
    {
        private readonly ITService _tService;

        public DoorOpenedController(ITService tService)
        {
            _tService = tService;
        }
        [HttpPost("OpenDoor")]
        public async Task<DoorOpened> OpenDoor(int ID, string DörrBenämning)
        {
            return await _tService.OpenDoor( ID, DörrBenämning);
        } 
    }
}
