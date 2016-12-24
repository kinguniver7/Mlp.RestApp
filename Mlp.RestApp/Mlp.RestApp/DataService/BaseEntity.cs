using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.DataService
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }

        //public static bool operator ==(BaseEntity<T, TKey> e1, BaseEntity<T, TKey> e2)
        //{
        //    if (object.ReferenceEquals(null, e1))
        //        return false;
        //    return e1.Equals(e2);
        //}
        //public static bool operator !=(BaseEntity<T, TKey> e1, BaseEntity<T, TKey> e2)
        //{
        //    return !(e1 == e2);
        //}

        public bool IsEmptyId()
        {
            var value = Convert.ChangeType(Id, typeof(TKey));
            bool result = false;
            var @switch = new Dictionary<Type, Action> {
                { typeof(int), () =>  result = (int)value == 0 },
                { typeof(string), () => result = string.IsNullOrWhiteSpace(value.ToString()) }
            };
            @switch[typeof(TKey)]();

            return result;
        }
    }
}
