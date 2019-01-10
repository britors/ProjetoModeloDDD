using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface ICustomerAppService : IAppServiceBase<Customer>
    {
        IEnumerable<Customer> GetOldCustomers();
    }
}
