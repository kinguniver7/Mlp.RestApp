using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.Domain
{
    public class Table : BaseModel
    {
        public string Name { get; set; }

        public Premises Premises { get; set; }
    }
}
