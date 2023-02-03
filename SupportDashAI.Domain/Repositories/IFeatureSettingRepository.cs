using SupportDashAI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Domain.Repositories
{
    public interface IFeatureSettingRepository
    {
        Task<FeatureSetting?> GetAsync(string key, string? userId);
        Task<FeatureSetting> SetAsync(string key, string value, string? userId);
        Task Save();
    }
}
