using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartphoneShop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }  

        public Category? Category { get; set; } 
        public int CategoryId { get; set; }
       
    }
}
