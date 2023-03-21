using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulkybook.Models
{
    public class Category 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        
        [Range(1,100,ErrorMessage = "Display error must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDatetime { get; set; } = DateTime.Now;   
    }
}

