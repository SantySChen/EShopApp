using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.ApplicationCore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Product_Category Product_Category { get; set; }
        public decimal? Price { get; set; }
        public int? Qty { get; set; }
        public string? Product_Image { get; set; }
        public string? SKU { get; set; }

        public ICollection<Product_Variation_Value> Product_Variation_Values {  get; set; } 

    }
}
