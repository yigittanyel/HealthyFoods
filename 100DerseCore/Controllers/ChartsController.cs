using _100DerseCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100DerseCore.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Statistics()
        {
            Context c = new Context();
            var toplamYemek = c.Foods.Count();
            ViewBag.d1 = toplamYemek;
            var toplamCategory = c.Categories.Count();
            ViewBag.d2 = toplamCategory;
            var foid = c.Categories.Where(x => x.Name == "Fruit").Select(y => y.CategoryId).FirstOrDefault();
            ViewBag.d = foid;
            var veid = c.Categories.Where(x => x.Name == "Vegetables").Select(y => y.CategoryId).FirstOrDefault();
            ViewBag.v = veid;
            var meyveSayısı = c.Foods.Where(x => x.CategoryId == foid).Count();
            ViewBag.d3 = meyveSayısı;
            var sebzeSayısı = c.Foods.Where(x => x.CategoryId == veid).Count();
            ViewBag.d4 = sebzeSayısı;
            var sumFood = c.Foods.Sum(x=>x.Stock);
            ViewBag.d5 = sumFood;
            var maxStokluFood = c.Foods.Sum(x => x.Stock);
            ViewBag.d5 = sumFood;
            return View();
        }
    }
}
