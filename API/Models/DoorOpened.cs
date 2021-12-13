namespace API.Models
{
    public class DoorOpened
    {
        public Guid? DoorOpenedId { get; set; }
        public int? TenantID{ get; set; }
        public int? DoorID{ get; set; }
        public TimeSpan? Time { get; set; }
    }
}
