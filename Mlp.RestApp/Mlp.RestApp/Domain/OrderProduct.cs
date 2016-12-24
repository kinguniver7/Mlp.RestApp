using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.Domain
{
    public class OrderProduct : Product
    {
        /// <summary>
        /// Count product
        /// </summary>
        public int Count { get; set; }
        
        /// <summary>
        /// Total price of product
        /// </summary>
        public double TotalPrice { get { return this.Price * this.Count; } }
    }
}
