using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Output
    {
        [Key]
        public int ID {get; set;}    
        public long? Time {get; set;}
        public string Code {get; set;}

        public string DörrBenämning { get; set; }
        public string Tag {get; set;}
        public string Person {get; set;}
       
       
    }
}
