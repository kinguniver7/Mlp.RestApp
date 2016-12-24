using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.Domain
{
    public class BaseModel
    {
        public string Id { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public bool Deleted { get; set; }
        
    }
}
