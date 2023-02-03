using Microsoft.EntityFrameworkCore;
using SupportDashAI.Domain.Repositories;
using SupportDashAI.Domain.Entities;
using SupportDashAI.EfCore.Data;

namespace SupportDashAI.EfCore.Repositories
{
    public class FeatureSettingRepository: IFeatureSettingRepository
    {
        private readonly ApplicationDbContext dbContext;

        public FeatureSettingRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<FeatureSetting?> GetAsync(string key, string? userId)
        {
            var setting = await dbContext.FeatureSettings
                .FirstOrDefaultAsync(s => s.Key == key && s.UserId == userId);
            if (setting == null)
            {
                return await dbContext.FeatureSettings.FirstOrDefaultAsync(s => s.Key == key && s.UserId == null);
            }
            return setting;
        }

        public async Task Save()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task<FeatureSetting> SetAsync(string key, string value, string? userId)
        {
            var setting = await dbContext.FeatureSettings.FirstOrDefaultAsync(s => s.Key == key && s.UserId == userId);
            if (setting == null)
            {
                setting = new FeatureSetting() { Id= Guid.NewGuid(), UserId = userId, Key = key, Value = value };
                await dbContext.FeatureSettings.AddAsync(setting);
            }
            setting.Value = value;
            return setting;
        }
    }
}
