using _100DerseCore.Models;
using _100DerseCore.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace _100DerseCore.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();
        CategoryRepositories cr = new CategoryRepositories();
        Category cat = new Category();
        public IActionResult Listele(int page=1)
        {
            //Arama için
            //if (!string.IsNullOrEmpty(p))
            //{
            //    return View(cr.List(x => x.Name == p));
            //}
                return View(cr.TList().ToPagedList(page, 3));
        }

        [HttpGet]
        public IActionResult CategoryEkle()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult CategoryEkle(Category p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryEkle");
            }

            cr.TAdd(p);
            return RedirectToAction("Listele");
        }

        //KATEGORİ SİL
        public IActionResult CategorySil(int id)
        {
            //cr.TDelete(new Category { CategoryId = id }) ;
            //return RedirectToAction("Listele");
            var d = c.Categories.Find(id);
            d.CategoryStatus = false ;
            cr.TUpdate(d);
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
    }
}
