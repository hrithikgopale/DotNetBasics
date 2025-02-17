using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspmvcAdopractice.Models
{
    public class ProductDAL
    {
        string cf = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        SqlConnection conn;

        public ProductDAL()
        {
            conn = new SqlConnection(cf);
            conn.Open();
        }
        public List<Product> GetAllProducts()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter("exec sp_show()", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Product> products = new List<Product>();

            foreach (DataRow dr in dt.Rows)
            {
                products.Add(new Product
                {
                    Id = int.Parse(dr["id"].ToString()),
                    pname = dr["pname"].ToString(),
                    pcat = dr["pcat"].ToString(),
                    price = double.Parse(dr["price"].ToString())
                }
                    );


            }
            return products;

        }

        public void AddProduct(Product p)
        {
            string q = $"exec sp_insert '{p.pname}',{p.pcat},{p.price}";
            SqlCommand cmd=new SqlCommand(q,conn);
            cmd.ExecuteNonQuery();

        }

        public void DeleteProduct(int id)
        {
            string q = $"exec sp_del {id}";
            SqlCommand cmd=new SqlCommand(q,conn);
            cmd.ExecuteNonQuery();

        }
      public void UpdateProduct(Product p)
        {
            string q = $"exec sp_update '','',''";
            SqlCommand cmd=new SqlCommand(q,conn);
            cmd.ExecuteNonQuery();
        }
    }
}