using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMicroservice.ApplicationCore.Entities
{
    public class Shopping_Cart_Item
    {
        public int Id { get; set; }
        public Shopping_Cart Shopping_Cart { get; set; }

        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
    }
}
