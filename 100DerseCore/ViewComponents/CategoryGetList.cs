using _100DerseCore.Models;
using _100DerseCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100DerseCore.ViewComponents
{
    public class CategoryGetList:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            CategoryRepositories cr = new CategoryRepositories();
            var categoryList = cr.TList();
            return View(categoryList);


            //Category cat = new Category();
            //CategoryRepositories cr = new CategoryRepositories();
            ////var categoryList = cr.TList();
            //if (cat.CategoryStatus == true)
            //{
            //    var categoryList = cr.TList();
            //    return View(categoryList);
            //}
            //return View();

        }
    }
}
