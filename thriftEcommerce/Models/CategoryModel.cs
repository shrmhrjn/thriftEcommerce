using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thriftEcommerce.Models
{
    public class CategoryModel
    {
        [Required]
        public int id { get; set; }
        [Required]
        [Stringlength(50)]
        public string name { get; set; }
        [Required]
        [String Length(100,Minimumlength(6))]
        public string description{get; set;}
    }
}
