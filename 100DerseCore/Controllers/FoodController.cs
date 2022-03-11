using _100DerseCore.Models;
using _100DerseCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace _100DerseCore.Controllers
{
    public class FoodController : Controller
    {
        Context c = new Context();
        FoodRepositories fr = new FoodRepositories();
        public IActionResult Listele(int page=1)
        {
            return View(fr.TList("Category").ToPagedList(page,3)); //Include eklenmiş haldeki TList metodu bu.
        }

        [HttpGet]
        public IActionResult FoodEkle()
        {
            List<SelectListItem> dep = (from x in c.Categories.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Name,
                                            Value = x.CategoryId.ToString()
                                        }).ToList();

            ViewBag.dp = dep;
            return View();
        }


        [HttpPost]
        public IActionResult FoodEkle(Food f)
        {
            fr.TAdd(f);
            return RedirectToAction("Listele");
        }

        //KATEGORİ SİL
        public IActionResult FoodSil(int id)
        {
            fr.TDelete(new Food { FoodId=id});
            return RedirectToAction("Listele");
        }

        //ID'YE GÖRE CATEGORY GETİRME
        public IActionResult CategoryGetir(int id)
        {
            //List<SelectListItem> dep = (from x in c.Categories.ToList()
            //                            select new SelectListItem
            //                            {
            //                                Text = x.Name,
            //                                Value = x.CategoryId.ToString()
            //                            }).ToList();
            //ViewBag.dp = dep;
            List<SelectListItem> der = (from x in c.Categories.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.CategoryStatus.ToString(),
                                            Value = x.CategoryId.ToString()
                                        }).ToList();
            ViewBag.dr = der;
            var d = c.Categories.Find(id);
            return View("CategoryGetir", d);
        }

        [HttpPost]
        public IActionResult CategoryGuncelle(Category p)
        {
            var x = c.Categories.FirstOrDefault(a => a.CategoryId == p.CategoryId);
            x.CategoryId = p.CategoryId;
            x.Name = p.Name;
            x.Desc = p.Desc;
            x.CategoryStatus = true;
            //x.CategoryStatus = p.CategoryStatus;
            c.SaveChanges();
            return RedirectToAction("Listele");
        }
        //ID'YE GÖRE YİYECEK GETİRME
        public IActionResult FoodGetir(int id)
        {
            List<SelectListItem> dep = (from x in c.Categories.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Name,
                                            Value = x.CategoryId.ToString()
                                        }).ToList();
            ViewBag.dr = dep;
            var d = c.Foods.Find(id);
            return View("FoodGetir", d);
        }

        [HttpPost]
        public IActionResult FoodGuncelle(Food p)
        {
            var x = c.Foods.FirstOrDefault(a => a.FoodId == p.FoodId);
            x.FoodId = p.FoodId;
            x.FName = p.FName;
            x.FoodDesc = p.FoodDesc;
            x.Price = p.Price;
            x.ImageUrl = p.ImageUrl;
            x.Stock = p.Stock;
            x.CategoryId = p.CategoryId;
            //x.CategoryStatus = p.CategoryStatus;
            c.SaveChanges();
            return RedirectToAction("Listele");
        }

    }
}
