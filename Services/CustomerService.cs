using CustomerInformationTracker.Infrastructure;
using CustomerInformationTracker.Infrastructure.Models;
using CustomerInformationTracker.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformationTracker.Services
{
    public class CustomerService : ICustomerService
        {
            private readonly CustomerDBContext _context;

            public CustomerService(CustomerDBContext context)
            {
                _context = context;
            }

            public async Task<List<Customer>> GetAllCustomersAsync()
            {
                return await _context.Customers.ToListAsync();
            }

            public async Task<Customer> GetCustomerByIdAsync(int id)
            {
                return await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
            }

            public async Task<Customer> CreateCustomerAsync(Customer customer)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return customer;
            }

            public async Task UpdateCustomerAsync(Customer customer)
            {
                _context.Entry(customer).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            public async Task DeleteCustomerAsync(int id)
            {
                var customer = await _context.Customers.FindAsync(id);
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    await _context.SaveChangesAsync();
                }
            }
        }

}
