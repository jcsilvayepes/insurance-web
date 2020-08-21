using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Application.Contracts
{
    public interface IServiceBase<TModel>
        where TModel : class
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync<TType>(TType id);
        Task<bool> CreateAsync(TModel modelType);
        Task<bool> EditAsync(TModel modelType);
        Task<bool> DeleteAsync<TType>(TType id);
    }
}
