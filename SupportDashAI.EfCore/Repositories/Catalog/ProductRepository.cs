using Microsoft.EntityFrameworkCore;
using SupportDashAI.Domain.Repositories.Catalog;
using SupportDashAI.Domain.Entities;
using SupportDashAI.EfCore.Data;

namespace SupportDashAI.EfCore.Repositories.Catalog
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task DeleteAsync(Guid productId)
        {
            var product = await dbContext.Products
                    .FirstAsync(c => c.Id == productId);
            dbContext.Remove(product);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetAsync(Guid productId)
        {
            return await dbContext.Products.FirstAsync(c => c.Id == productId);
        }

        public async Task<IEnumerable<Product>> GetListAsync(int skipCount, string criteria)
        {
            return await dbContext.Products
                .Include(p => p.Category)
                .Where(c => c.Name.Contains(criteria) || c.Description.Contains(criteria))
                .Skip(skipCount)
                .ToListAsync();
        }

        public async Task InsertAsync(Product product)
        {
            await dbContext.AddAsync(product);
        }

        public async Task Save()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            var entity = dbContext.Products.Find(product.Id);
            if (entity == null)
            {
                return;
            }

            dbContext.Products.Entry(entity).CurrentValues.SetValues(product);
        }
    }
}
