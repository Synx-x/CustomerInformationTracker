using CustomerInformationTracker.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformationTracker.Infrastructure
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
