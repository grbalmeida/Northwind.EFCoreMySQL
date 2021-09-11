using System.Collections.Generic;

namespace Northwind.EFCore.Models
{
    public class CustomerDemographics
    {
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }

        public ICollection<CustomerCustomerDemo> CustomerDemos { get; set; }
    }
}
