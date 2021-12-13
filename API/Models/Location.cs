using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        
     

        public List<Door> Doors { get; set; }
        public List<Tenant> Tenants { get; set; }

    }
}
