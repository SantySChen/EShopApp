using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.ApplicationCore.Entities
{
    public class Product_Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Parent_Category_Id { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Category_Variation> Category_Variations { get; set; }


    }
}
