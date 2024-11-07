using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMicroservice.ApplicationCore.Entities
{
    public class Payment_Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Payment_Method> Payment_Methods { get; set; }
    }
}
