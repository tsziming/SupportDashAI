using Microsoft.Extensions.DependencyInjection;
using SupportDashAI.Domain.Repositories;
using SupportDashAI.Domain.Repositories.Catalog;
using SupportDashAI.EfCore.Repositories;
using SupportDashAI.EfCore.Repositories.Catalog;


namespace SupportDashAI.EfCore
{
    public static class SupportDashAIEfCoreModuleExtensions
    {
        public static IServiceCollection AddEfCoreServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IAgentRepository, AgentRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IFeatureSettingRepository, FeatureSettingRepository>();

            // TODO: more services
            return services;
        }
    }
}
