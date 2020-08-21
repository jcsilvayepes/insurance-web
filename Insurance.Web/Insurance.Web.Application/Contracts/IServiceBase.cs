using System.Collections.Generic;
using System.Threading.Tasks;

namespace Insurance.Web.Application.Contracts
{
    public interface IServiceBase<T>
        where T : class
    {
        Task<bool> Create(T riskType);
        Task<bool> Edit(T riskType);
        Task<bool> Delete<TType>(TType id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById<TType>(TType id);
    }
}
