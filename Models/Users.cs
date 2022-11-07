using System.ComponentModel.DataAnnotations;

namespace BlogAppWeb.Models
{
    public class Users
    {
        [Key]
        public int userID { get; private set; }
        public string? FullName { get; private set; }
        public string? UserEmail { get; set; }
        public string Username { get; private set; } = " ";
        public bool IsAdmin { get; private set; } = false;
        public DateTime? Created { get; set; } = DateTime.Now;


    }
}
