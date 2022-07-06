using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore_MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required, MaxLength(50), DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required, MaxLength(100), DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required,MaxLength(15),DisplayName("Phonenumber")]
        public string PhoneNumber { get; set; }
        public ICollection<CustomerBooks> CustomerBook { get; set; }

    }
}
