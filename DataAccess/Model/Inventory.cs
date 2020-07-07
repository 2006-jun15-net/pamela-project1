using System;
using System.Collections.Generic;

namespace pamela_project1.DataAccess.Model
{

    /// <summary>
    /// Junction table Inventory, with an associated location, product, and product quantity available
    /// </summary>
    public partial class Inventory 
    {
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
