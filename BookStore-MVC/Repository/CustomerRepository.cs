using BookStore_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookStore_MVC.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private BookStoreDbContext _context = null;
        private DbSet<Customer> CustomerTable = null;
        public CustomerRepository()
        {
            this._context = new BookStoreDbContext();
            CustomerTable = _context.Set<Customer>();

        }
        public CustomerRepository(BookStoreDbContext _context)
        {
            this._context = _context;
            CustomerTable = _context.Set<Customer>();
        }

        public void CreateCustomer(Customer customer)
        {
            CustomerTable.Add(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return CustomerTable.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return CustomerTable.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = CustomerTable.Find(id);
            CustomerTable.Remove(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            CustomerTable.Attach(customer);
            _context.Entry(customer).State = EntityState.Modified;  
        }
    }
}
