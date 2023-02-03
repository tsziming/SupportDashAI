using Microsoft.EntityFrameworkCore;
using SupportDashAI.Domain.Repositories;
using SupportDashAI.Domain.Entities;
using SupportDashAI.EfCore.Data;
using System.Linq;

namespace SupportDashAI.EfCore.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CustomerRepository(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public async Task DeleteAsync(Guid customerId)
        {
            Customer customer = await dbContext.Customers.FirstAsync(
                c => c.Id == customerId);
            dbContext.Customers.Remove(customer);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await dbContext.Customers
                .ToListAsync();
        }

        public async Task<Customer> GetAsync(Guid customerId)
        {
            return await dbContext.Customers
                .FirstAsync(c => c.Id == customerId);
        }

        public async Task<IEnumerable<Customer>> GetByAgentAsync(string agentId)
        {
            return await dbContext.Customers
                .Where(c => c.Agent != null && c.Agent.Id == agentId)
                .OrderByDescending(c => c.Requests.Count > 0 ? c.Requests.Select(r => r.SentDate).Max() : DateTime.MinValue)
                .ToListAsync();
        }

        public async Task InsertAsync(Customer customer)
        {
            await dbContext.AddAsync(customer);
        }

        public async Task Save()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            var entity = dbContext.Customers.Find(customer.Id);
            if (entity == null)
            {
                return;
            }

            dbContext.Customers.Entry(entity).CurrentValues.SetValues(customer);
        }
    }
}
