using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100DerseCore.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FName { get; set; }
        public string FoodDesc { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
