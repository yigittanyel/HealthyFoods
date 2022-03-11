using _100DerseCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100DerseCore.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.d1 = id;
            FoodRepositories cr = new FoodRepositories();
            //RASTGELE 4 DEĞERİ ALDIK.
            var foodList = cr.List(x => x.CategoryId == id);
            return View(foodList);
        }
    }
}
