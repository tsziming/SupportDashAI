using SupportDashAI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Domain.Repositories.Catalog
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<Category>> GetListAsync(int skipCount, string criteria);
        Task<Category> GetAsync(Guid categoryId);
        Task InsertAsync(Category category);
        Task DeleteAsync(Guid categoryId);
        Task UpdateAsync(Category category);
        Task Save();
    }
}
