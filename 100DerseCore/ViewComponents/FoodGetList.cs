using _100DerseCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100DerseCore.ViewComponents
{
    public class FoodGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FoodRepositories cr = new FoodRepositories();
            //RASTGELE 4 DEĞERİ ALDIK.
            var foodList = cr.TList().OrderByDescending(x=>Guid.NewGuid()).Take(4);
            return View(foodList);
        }
    }
}
