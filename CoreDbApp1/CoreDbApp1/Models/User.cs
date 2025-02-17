using System.ComponentModel.DataAnnotations;

namespace CoreDbApp1.Models
{
    public class User
    {
        [Key]
       public int Id { get; set; }
        [Required(ErrorMessage ="Enter Username")]
       public string Name { get; set; }

        [Required(ErrorMessage ="Enter EmailId")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter Password")]
        public string Password { get; set; }
    }
}
