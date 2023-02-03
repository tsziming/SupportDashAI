using Microsoft.Extensions.DependencyInjection;
using SupportDashAI.Application.Services;
using SupportDashAI.Application.Services.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Application
{
    public static class SupportDashAIApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperApplicationProfile));
            services.AddScoped<FeatureSettingAppService>();
            services.AddScoped<CategoryAppService>();
            services.AddScoped<ProductAppService>();
            services.AddScoped<CustomerAppService>();

            // TODO: more services
            return services;
        }
    }
}
