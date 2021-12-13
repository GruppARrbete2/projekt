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

   
     

       public async Task<DoorOpened> OpenDoor(int ID, string DörrBenämning)
        {
            var user = await _templateDBContext.Tenants.FirstOrDefaultAsync(tenants => tenants.TenantID == ID);
            var Door = await _templateDBContext.Doors.FirstOrDefaultAsync(door => door.DörrBenämning == DörrBenämning);

            if (user != null && Door != null)
            {
                var userOpenDoor = new DoorOpened
                {
                    TenantID = user.TenantID,
                    Time = DateTime.Now.TimeOfDay,
                    DoorOpenedId = new Guid(),
                    DoorID = Door.DoorID,
                    
            };
                _templateDBContext.SaveChanges();
                return userOpenDoor;


            }


            else
            {
                return null;
            }
        }
    }
}
