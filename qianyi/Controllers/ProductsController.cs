using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using qianyi.Data;
using qianyi.Models;

namespace qianyi.Controllers
{
    public class ProductsController : Controller
    {
        private qianyiContext db = new qianyiContext();

        // GET: Products
       
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

         
                // 从数据库中检索产品数据并填充products列表
                products = db.Products.ToList();
            
            return View(products);
        }
        public ActionResult  C()
        {
            List<Product> products = new List<Product>();
            // 从数据库中检索产品数据并填充products列表
            products = db.Products.ToList();

            return View(products);
        }

    }
}
