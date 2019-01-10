using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        IEnumerable<Customer> GetOldCustomers(IEnumerable<Customer> customers);
    }
}
