using System.ComponentModel.DataAnnotations;

namespace AuthTest.Models
{
    public class User
    {
        [Key]
        public int id {  get; set; }

        [Required]
        public string username { get; set; }
        [Required]
        public string email {  get; set; }
        [Required]
        public string password { get; set; }
        public string role {  get; set; }

    }
}
