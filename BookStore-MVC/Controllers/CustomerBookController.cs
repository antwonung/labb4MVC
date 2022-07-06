using BookStore_MVC.Models;
using BookStore_MVC.Repository;
using BookStore_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_MVC.Controllers
{
    public class CustomerBookController : Controller
    {
        private readonly ICustomerBook _customerBookRepo = null;
      
        public CustomerBookController(ICustomerBook customerBookRepo)
        {
            this._customerBookRepo = customerBookRepo;
        }

        public IActionResult CustomersBooks(int id)
        {
            CustomerBookViewModel viewModel = new CustomerBookViewModel();

            viewModel.customerbooks = _customerBookRepo.customerBooks(id);

            return View(viewModel);
            

        }
   
    }
}
