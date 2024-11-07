using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionsMicroservice.ApplicatonCore.Entities
{
    public class Promotion_Detail
    {
        public int Id { get; set; }
        public Promotion_Sale Promotion_Sale { get; set; }
        public int Product_Category_Id { get; set; }
        public string Product_Category_Name { get; set; }
    }
}
