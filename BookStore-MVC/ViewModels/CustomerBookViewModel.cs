using BookStore_MVC.Models;
using System.Collections.Generic;

namespace BookStore_MVC.ViewModels
{
    public class CustomerBookViewModel
    {
        public IEnumerable<CustomerBooks> customerbooks { get; set; }


    }
}
