using Microsoft.EntityFrameworkCore;
using SupportDashAI.Domain.Repositories.Catalog;
using SupportDashAI.Domain.Entities;
using SupportDashAI.EfCore.Data;

namespace SupportDashAI.EfCore.Repositories.Catalog
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task DeleteAsync(Guid categoryId)
        {
            var category = await dbContext.Categories
                    .FirstAsync(c => c.Id == categoryId);
            dbContext.Remove(category);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await dbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetAsync(Guid categoryId)
        {
            return await dbContext.Categories.FirstAsync(c => c.Id == categoryId);
        }

        public async Task<IEnumerable<Category>> GetListAsync(int skipCount, string criteria)
        {
            return await dbContext.Categories
                .Where(c => c.Name.Contains(criteria) || c.Description.Contains(criteria))
                .Skip(skipCount)
                .ToListAsync();
        }

        public async Task InsertAsync(Category category)
        {
            await dbContext.AddAsync(category);
        }

        public async Task Save()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            var entity = dbContext.Categories.Find(category.Id);
            if (entity == null)
            {
                return;
            }

            dbContext.Categories.Entry(entity).CurrentValues.SetValues(category);
        }
    }
}
