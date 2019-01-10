using AutoMapper;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerAppService _customerApp;

        public CustomerController(ICustomerAppService customerApp)
        {
            _customerApp = customerApp;
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(_customerApp.GetAll());
            return View(customers);
        }

    }
}
