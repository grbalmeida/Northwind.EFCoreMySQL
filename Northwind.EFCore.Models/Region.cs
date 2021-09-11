using System.Collections.Generic;

namespace Northwind.EFCore.Models
{
    public class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public ICollection<Territory> Territories { get; set; }
    }
}
