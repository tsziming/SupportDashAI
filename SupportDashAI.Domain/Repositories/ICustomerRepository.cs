using SupportDashAI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<IEnumerable<Customer>> GetByAgentAsync(string agentId);
        Task<Customer> GetAsync(Guid customerId);
        Task InsertAsync(Customer customer);
        Task DeleteAsync(Guid customerId);
        Task UpdateAsync(Customer customer);
        Task Save();
    }
}
