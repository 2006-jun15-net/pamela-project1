﻿using System;
using System.Collections.Generic;

namespace pamela_project1.DataAccess.Model
{
    /// <summary>
    /// Data Access Entity Orders, with an ID number and associated customer and location, and date/time that the order was placed on
    /// </summary>
    public partial class Orders 
    { 
        public Orders()
        {
            OrderLine = new HashSet<OrderLine>();
        }

        public int OrderId { get; set; }
        public int LocationId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        

        public virtual Customer Customer { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
