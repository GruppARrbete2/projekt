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
            public async Task<List<Output>> FindEntriesByDoor(string name)
            {
                return await _doorService.FindEntriesByDoor(name);
            }

        [HttpGet("FindEntriesByCode")]
        public async Task<List<Output>> FindEntriesByCode(string name)
        {
            return await _doorService.FindEntriesByCode(name);
        }

        [HttpGet("FindEntriesByTag")]
        public async Task<List<Output>> FindEntriesByTag(string name)
        {
            return await _doorService.FindEntriesByTag(name);
        }



        [HttpPost("CreateData")]
        public async Task<Output> CreateData(string dörrBenämning, string code, string tag, string person, string codeExplanation)
        {
            return await _doorService.CreateData(dörrBenämning , code , tag , person , codeExplanation);
        }
    }
    }

