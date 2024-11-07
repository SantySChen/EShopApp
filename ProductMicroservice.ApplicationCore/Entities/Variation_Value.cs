using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.ApplicationCore.Entities
{
    public class Variation_Value
    {
        public int Id { get; set; }
        public Category_Variation Category_Variation { get; set; }
        public string Value { get; set; }
        public ICollection<Product_Variation_Value> Product_Variation_Values { get; set; }
    }
}
