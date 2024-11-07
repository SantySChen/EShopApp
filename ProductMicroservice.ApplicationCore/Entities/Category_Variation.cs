using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.ApplicationCore.Entities
{
    public class Category_Variation
    {
        public int Id { get; set; }
        public Product_Category Product_Category { get; set; }
        public string? Variation_Name { get; set; }

        public ICollection<Variation_Value> Variation_Values { get; set; }

        
    }
}
