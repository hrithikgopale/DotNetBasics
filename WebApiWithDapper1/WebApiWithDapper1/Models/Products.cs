using System.ComponentModel.DataAnnotations;

namespace WebApiWithDapper1.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal price { get; set; }
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
