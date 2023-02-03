using SupportDashAI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Domain.Repositories.Catalog
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetListAsync(int skipCount, string criteria);
        Task<Product> GetAsync(Guid productId);
        Task InsertAsync(Product product);
        Task DeleteAsync(Guid productId);
        Task UpdateAsync(Product product);  
        Task Save();
    }
}
