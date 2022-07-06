using BookStore_MVC.Models;
using System.Collections.Generic;

namespace BookStore_MVC.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer customer);
        void Save();
        void CreateCustomer(Customer customer);
        void DeleteCustomer(int id);

    }
}
