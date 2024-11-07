using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.ApplicationCore.Entities
{
    public class Product_Variation_Value
    {
        public int Product_Id { get; set; }
        public Product Product { get; set; }
        public int Variation_Value_Id {  get; set; }
        public Variation_Value Variation_Value { get; set; }
        
    }
}
