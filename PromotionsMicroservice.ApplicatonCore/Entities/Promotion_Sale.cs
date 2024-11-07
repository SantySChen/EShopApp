using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionsMicroservice.ApplicatonCore.Entities
{
    public class Promotion_Sale
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }
        public decimal? Discount { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime? End_Date { get; set; }

    }
}
