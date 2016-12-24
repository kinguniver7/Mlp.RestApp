using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.Domain
{
    /// <summary>
    /// Room, floor, bulding
    /// </summary>
    public class Premises
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Premises Parent { get; set; }
    }
}
