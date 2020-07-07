using System;
using System.Collections.Generic;

namespace pamela_project1.DataAccess.Model
{
    /// <summary>
    /// Data Access Entity Location, with a store name and ID number
    /// </summary>
    public partial class Location 
    {
        public Location()
        {
            Inventory = new HashSet<Inventory>();
            Orders = new HashSet<Orders>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
