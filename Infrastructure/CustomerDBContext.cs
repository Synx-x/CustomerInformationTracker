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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var customers = new List<Customer>();

            var names = new List<string> { "Sipho", "Thabo", "Naledi", "Lerato", "Tumi", "Kagiso", "Mpho", "Amandla", "Siyanda", "Themba", "Nandi", "Fikile", "Ayanda", "Thandiwe", "Lindiwe", "Siya", "Senzo", "Nomzamo", "Bongani", "Sibusiso" };
            var cities = new List<string> { "Johannesburg", "Cape Town", "Durban", "East London", "Port Elizabeth", "Bloemfontein", "Nelspruit", "Kimberley", "Polokwane", "Pietermaritzburg" };

            for (int i = 1; i <= 20; i++)
            {
                var cityIndex = (i - 1) % cities.Count; // Ensure it's zero-based and loops within the range
                var nameIndex = (i - 1) % names.Count; // Use modulo to cycle through names if needed
                customers.Add(new Customer
                {
                    Id = -i,
                    Name = names[nameIndex],
                    Address = $"{i} Main Rd, {cities[cityIndex]}",
                    TelephoneNumber = $"(+27) 67 {100 + i} 00{i.ToString().PadLeft(2, '0')}",
                    ContactPersonName = $"Contact {names[nameIndex]}",
                    ContactPersonEmailAddress = $"{names[nameIndex].ToLower()}@arksoft.co.za",
                    VATNumber = $"VAT00{i}"
                });
            }

            modelBuilder.Entity<Customer>().HasData(customers);
        }
    }
}
