using BookStore_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookStore_MVC.Repository
{
    public class CustomerBookRepository : ICustomerBook
    {
        private readonly BookStoreDbContext _dbContext;
        public CustomerBookRepository(BookStoreDbContext context)
        {
            _dbContext = context;
        }
        public List<CustomerBooks> customerBooks(int id)
        {
            return _dbContext.CustomerBooks.Include(d => d.customer).Include(b => b.books).Where(c => c.CustomerId == id).ToList();
        }

     
    }
}
