using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApiWithDapper1.Models;

namespace WebApiWithDapper1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly string connectionstring;
        public ProductsController(IConfiguration configuration)
        {
            connectionstring = configuration.GetConnectionString("dbconn")!;
        }
        [HttpPost("Create")]
        public IActionResult Create(ProductsDto productsDto)
        {
            try
            {
                using (var connection = new SqlConnection())
                {
                    connection.Open();
                    //write a query
                    string sql = "insert into products" + "(Name,Brand,category,price,Description,CreatedAt)" + "Values(@Name,@Brand,@Category,@price,@Description,@CreatedAt)";
                    var Products = new Products()
                    {
                        Name = productsDto.Name,
                        Brand = productsDto.Brand,
                        Category = productsDto.Category,
                        price = productsDto.price,
                        Description = productsDto.Description,
                        CreatedAt = DateTime.Now,
                    };

                    var newproduct = connection.QuerySingle<Products>(sql, Products);
                    if (newproduct != null)
                    {
                        return Ok(newproduct);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return BadRequest();
        }

    }
}
