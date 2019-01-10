using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
