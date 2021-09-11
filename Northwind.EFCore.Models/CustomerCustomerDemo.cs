namespace Northwind.EFCore.Models
{
    public class CustomerCustomerDemo
    {
        public string CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string CustomerTypeID { get; set; }
        public CustomerDemographics CustomerDemographics { get; set; }
    }
}
