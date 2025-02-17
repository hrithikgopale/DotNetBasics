using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppWithutEntityFramework.Models
{
    public class Product
    {
      
        public string pname { get; set; }
        public string pcat { get; set; }

        public double price { get; set; }
        public int Id { get; internal set; }
    }
}