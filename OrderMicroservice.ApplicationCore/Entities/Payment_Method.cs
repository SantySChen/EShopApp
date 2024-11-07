using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMicroservice.ApplicationCore.Entities
{
    public class Payment_Method
    {
        public int Id { get; set; }
        public Payment_Type Payment_Type { get; set; }
        public string? Provider { get; set; }
        public string? AccountNumber { get; set; }
        public DateTime? Expiry {  get; set; }
        public bool IsDefault { get; set; }

    }
}
