using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Template
    {
        [Key]
        public int TemplateID { get; set; }

      
        public string? TemplateString { get; set; }
    }
}
