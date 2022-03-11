using _100DerseCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace _100DerseCore.Repositories
{
    public class GenericRepository<T> where T:class,new()
    {
        Context c = new Context();
        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public List<T> TList(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }
        public void TAdd(T cy)
        {
            c.Set<T>().Add(cy);
            c.SaveChanges();
        }
        public void TDelete(T cy)
        {
            c.Set<T>().Remove(cy);
            c.SaveChanges();
        }
        public void TUpdate(T cy)
        {
            c.Set<T>().Update(cy);
            c.SaveChanges();
        }
        public void TGet(int id)
        {
            c.Set<T>().Find(id);
        }
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
