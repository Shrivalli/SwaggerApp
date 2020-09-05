using System;
using System.Collections.Generic;

namespace SwaggerEg.Models
{
    public partial class Cust
    {
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IsMember { get; set; }
        public string OrderStatus { get; set; }
    }
}
