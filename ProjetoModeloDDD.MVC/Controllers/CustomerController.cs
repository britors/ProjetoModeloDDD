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

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var customer = Mapper.Map<Customer, CustomerViewModel>(_customerApp.GetById(id));
            return View(customer);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(CustomerViewModel customerViewModel)
        {
            try
            {
                var customer = Mapper.Map<CustomerViewModel, Customer>(customerViewModel);
                _customerApp.Add(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = Mapper.Map<Customer, CustomerViewModel>(_customerApp.GetById(id));
            return View(customer);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CustomerViewModel customerViewModel)
        {
            try
            {
                var customer = Mapper.Map<CustomerViewModel, Customer>(customerViewModel);
                _customerApp.Update(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = Mapper.Map<Customer, CustomerViewModel>(_customerApp.GetById(id));
            return View(customer);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CustomerViewModel customerViewModel)
        {
            try
            {
                var customer = _customerApp.GetById(id);
                _customerApp.Remove(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
