using System;
using System.Collections.Generic;

namespace pamela_project1.DataAccess.Model
{
    /// <summary>
    /// Junction table Orderline
    /// </summary>
    public partial class OrderLine
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Orders Order { get; set; } 
        public virtual Product Product { get; set; }
    }
}