using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Output
    {
        [Key]
        public int ID {get; set;}    
        public TimeSpan? Time {get; set;}
        public string Code {get; set;}
        public string Tag {get; set;}
        public string Person {get; set;}
        public string CodeExplation {get; set;}
        public string DörrBenämning {get; set;}
    }
}
