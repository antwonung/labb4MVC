using BookStore_MVC.Models;
using System.Collections.Generic;

namespace BookStore_MVC.Repository
{
    public interface ICustomerBook
    {
        List<CustomerBooks> customerBooks(int id);
    }
}
