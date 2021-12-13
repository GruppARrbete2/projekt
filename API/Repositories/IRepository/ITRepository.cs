
using API.Models;
using System.Drawing;

namespace API.Repositories
{
    public interface ITRepository
{
         Task<DoorOpened> OpenDoor(int ID, string DörrBenämning);
      
    }
}
