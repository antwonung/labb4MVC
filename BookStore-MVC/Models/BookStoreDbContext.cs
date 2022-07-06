using Microsoft.EntityFrameworkCore;

namespace BookStore_MVC.Models
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext()
        {
        }

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {}
        public DbSet<Books> books { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<CustomerBooks> CustomerBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<CustomerBooks>()
                .HasKey(bc => new {bc.CustomerId, bc.BookId});
            modelbuilder.Entity<CustomerBooks>()
                .HasOne(bc => bc.books)
                .WithMany(b => b.CustomerBook)
                .HasForeignKey(bc => bc.BookId);
            modelbuilder.Entity<CustomerBooks>()
                .HasOne(bc => bc.customer)
                .WithMany(c => c.CustomerBook)
                .HasForeignKey(bc => bc.CustomerId);
        }

    }
}
