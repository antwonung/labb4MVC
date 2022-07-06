using BookStore_MVC.Models;
using BookStore_MVC.Repository;
using BookStore_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStore_MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository = null;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
                
        }

        public IActionResult CustomerList()
        {
            CustomerViewModel customerViewModel = new CustomerViewModel();
            customerViewModel.customerViewMdl = _customerRepository.GetAll();
            return View(customerViewModel);
        }
        public IActionResult Customer()
        {
            return View();
        }

        public IActionResult SearchCustomer()
        {
            return View();
        }
        public IActionResult GetCustomer(int customerID)
        {
            CustomerViewModel customerViewModel = new CustomerViewModel();
            customerViewModel.customer = _customerRepository.GetCustomerById(customerID);
            customerViewModel.customerViewMdl = _customerRepository.GetAll();
            return View(customerViewModel);
        }
        [HttpPost]
        public IActionResult RegisterCustomer(Customer customer)
        {
            _customerRepository.CreateCustomer(customer);
            _customerRepository.Save();
            return RedirectToAction("CustomerList");
        }

        [HttpGet]
        public IActionResult DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
            _customerRepository.Save();
            return RedirectToAction("CustomerList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            BookStoreDbContext db = new BookStoreDbContext();
            Customer customer = _customerRepository.GetCustomerById(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.UpdateCustomer(customer);
                _customerRepository.Save();
                return RedirectToAction("CustomerList");
            }
            else
            {
                return View(customer);
            }
         
        }

    }
}
