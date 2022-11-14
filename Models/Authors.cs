using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogAppWeb.Models
{
    public class Authors
    {
        [Key]
        [Required]
        public int AuthorID { get; set; }

        [ForeignKey("Users")]
        [Required]
        public int userID { get; set; } 

        public string? FullName { get; set; }

    }
}
