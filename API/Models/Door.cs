using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Door
    {
        [Key]
        public int DoorID {get; set;}
        public string? DörrBenämning {get; set;}
        public string? Explanation {get; set;}
    }
}
