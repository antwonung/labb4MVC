using BookStore_MVC.Models;
using System.Collections.Generic;

namespace BookStore_MVC.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<Customer> customerViewMdl { get; set; }
        public IEnumerable<CustomerBooks> customerBooks { get; set; }
        public Customer customer { get; set; }


    }
}
