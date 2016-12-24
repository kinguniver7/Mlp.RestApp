using Mlp.RestApp.DataService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlp.RestApp.DataService
{
    public interface IRepository<T> 
        where T : BaseEntity<int>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Save(T entity);
        int Delete(T entity);
    }
}
