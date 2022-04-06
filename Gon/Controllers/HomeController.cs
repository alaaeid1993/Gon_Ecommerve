using Gon.Data;
using Gon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Gon.Controllers
{
    public class HomeController : Controller
    {
        Gon__Context db;

        public HomeController(Gon__Context _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            List<Product> pro = db.Products.ToList();
            ViewData["cate"] = db.Categories.ToList();
            return View(pro);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult dashboard()
        {
            ViewData["dd"] = db.Products.Count().ToString();
            List<Product> pro = db.Products.ToList();
            return View(pro);
        }

    }
}
