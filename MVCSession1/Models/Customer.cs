using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSession1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
 
        public string Address { get; set; }
        public string PostCode { get; set; }
        public int StateId { get; set; }
    }
}