using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppWithutEntityFramework.Models;

namespace WebAppWithutEntityFramework.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        ProductDAL pd=new ProductDAL();
        public ActionResult Index()
        {
           var data=pd.GetAllProducts();
            return View(data);
        }

    }
}