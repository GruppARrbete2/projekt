using API.Models;

namespace API.Services.IServices
{
    public interface ITService
    {
        Task<DoorOpened> OpenDoor(int ID, string DörrBenämning);
      
    }
}