using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore_MVC.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        [Required, MaxLength(100)]
        public string BookTitle { get; set; }
        [Required,MaxLength(200)]
        public string BookAuthor { get; set; }
        [Required,Range(0,20)]
        public int BooksInStore { get; set; }
        [Required,Range(0,20)]
        public int RentedBooks { get; set; }
        public ICollection<CustomerBooks> CustomerBook { get; set; }
    }
}
