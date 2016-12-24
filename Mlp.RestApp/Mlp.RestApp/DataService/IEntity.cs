using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.DataService
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
