using _100DerseCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100DerseCore.Repositories
{
    public class CategoryRepositories:GenericRepository<Category>
    {

        // GENERIC REPOSITORY OLMASA HEPSİ İÇİN TEK TEK BU ŞEKİLDE TANIMLAMAMIZ GEREKİR.

        //Context c = new Context();
        //public List<Category> CategoryList()
        //{
        //    return c.Categories.ToList();
        //}
        //public void CategoryAdd(Category cy)
        //{
        //    c.Categories.Add(cy);
        //    c.SaveChanges();
        //}
        //public void CategoryDelete(Category cy)
        //{
        //    c.Categories.Remove(cy);
        //    c.SaveChanges();
        //}
        //public void CategoryUpdate(Category cy)
        //{
        //    c.Categories.Update(cy);
        //    c.SaveChanges();
        //}
        //public void GetCategory(int id)
        //{
        //    c.Categories.Find(id);
        //}
    }
}
