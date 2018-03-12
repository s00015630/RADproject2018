using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace RADproject2018.Models.DAL
{
    public interface IRepository<T>
    {
        Task<IList<T>> getEntities();
        Task<T> GetEntity(int id);
        Task<T> PutEntity(T Entity);
        Task<T> PostEntity(T Entity);
        Task<T> delete(int id);
    }
}