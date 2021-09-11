using System.Collections.Generic;

namespace Northwind.EFCore.Models
{
    public class Territory
    {
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public Region Region { get; set; }

        public ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
