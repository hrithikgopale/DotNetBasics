using AspmvcAdopractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspmvcAdopractice.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        ProductDAL ob = new ProductDAL();
        public ActionResult Index()
        {

          var data=ob.GetAllProducts();
            return View(data);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
             ob.AddProduct(p);
            TempData["success"] = "<script>('Product Added Successfully');</script>";
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var data= ob.GetAllProducts().Find(x=>x.Id.Equals(id));
            return View(data);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product p)
        {
            ob.UpdateProduct(p);
            TempData["success"] = "<script>('Product Updated Successfully');</script>";
            return RedirectToAction("Index");
        }
    }
}