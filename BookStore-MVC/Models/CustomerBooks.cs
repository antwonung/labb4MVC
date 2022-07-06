using System;

namespace BookStore_MVC.Models
{
    public class CustomerBooks
    {
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public int BookId { get; set; }
        public Books books { get; set; }
        public string StartDate { get; set; }
        public string ReturnDate { get; set; }
        public bool ReturnedOrNot { get; set; }


    }
}
