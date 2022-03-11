using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _100DerseCore.Models
{

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Kategori Adı Boş Geçilemez!")]
        [MaxLength(25, ErrorMessage = "İsim Alanı 25 Karakterden Büyük olamaz")]
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool CategoryStatus { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
