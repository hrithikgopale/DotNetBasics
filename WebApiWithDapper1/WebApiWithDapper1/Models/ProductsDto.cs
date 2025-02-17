namespace WebApiWithDapper1.Models
{
    public class ProductsDto
    {
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal price { get; set; }
        public string Description { get; set; } = "";
    }
}
