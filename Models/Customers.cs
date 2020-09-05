using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string UserId { get; set; }
        public string Msg { get; set; }
        public string City { get; set; }
    }
}
