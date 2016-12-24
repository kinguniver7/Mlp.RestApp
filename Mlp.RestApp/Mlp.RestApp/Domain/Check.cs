using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mlp.RestApp.Domain
{
    public class Check : BaseModel
    {
        public IEnumerable<OrderProduct> OrderProducts { get; set; }

        /// <summary>
        /// Table of check
        /// </summary>
        public Table Table { get; set; }

        /// <summary>
        /// Total price of check
        /// </summary>
        public double TotalPrice { get { return this.OrderProducts.Sum(c => c.TotalPrice); } }
    }
}
