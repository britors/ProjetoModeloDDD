using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class CustomerAppService : AppServiceBase<Customer>, ICustomerAppService
    {
        private readonly ICustomerService _customerService;
            
        public CustomerAppService(ICustomerService customerService)
            :base(customerService)
        {
            _customerService = customerService;
        }

        public IEnumerable<Customer> GetOldCustomers()
        {
            return _customerService.GetOldCustomers(_customerService.GetAll());
        }
    }
}
