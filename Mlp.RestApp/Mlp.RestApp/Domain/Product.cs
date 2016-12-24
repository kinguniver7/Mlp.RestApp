using Mlp.RestApp.DataService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.Domain
{
    /// <summary>
    /// Product
    /// </summary>
    public partial class Product : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public string CategoryId { get; set; }
               

    }
}
