using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
            : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetOldCustomers(IEnumerable<Customer> customers)
        {
            return customers.Where(c => c.IsOldCustomer(c));
        }
    }
}
