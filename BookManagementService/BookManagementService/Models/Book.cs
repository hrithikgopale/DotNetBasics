using System.ComponentModel.DataAnnotations;

namespace BookManagementService.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public double price {  get; set; }
    }
}
