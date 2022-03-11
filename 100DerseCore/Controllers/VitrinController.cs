using _100DerseCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _100DerseCore.Models;
namespace _100DerseCore.Controllers
{
    public class VitrinController : Controller
    {
        CategoryRepositories cr = new CategoryRepositories();
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryDetails(int id)
        {
            ViewBag.d1 = id;
            return View();
        }
    }
}
