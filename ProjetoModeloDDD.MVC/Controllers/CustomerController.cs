using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Repositories;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerRepository customerRepository = new CustomerRepository();

        // GET: Customer
        public ActionResult Index()
        {
            var customers = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(customerRepository.GetAll());
            return View(customers);
        }

    }
}
