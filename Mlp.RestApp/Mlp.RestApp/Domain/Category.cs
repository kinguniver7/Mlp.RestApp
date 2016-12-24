using Mlp.RestApp.DataService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.Domain
{
    public partial class Category : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string ParentCategoryId { get; set; }
                
    }
}
