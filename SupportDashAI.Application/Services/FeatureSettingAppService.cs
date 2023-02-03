using AutoMapper;
using SupportDashAI.Contracts.Dto;
using SupportDashAI.Domain.Repositories;
using SupportDashAI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Application.Services
{
    public class FeatureSettingAppService
    {
        private readonly IFeatureSettingRepository repository;
        private readonly IMapper mapper;

        public FeatureSettingAppService(
            IFeatureSettingRepository repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<FeatureSettingDto> Set(FeatureSettingDto setting) 
        {
            var newSetting = await repository.SetAsync(setting.Key, setting.Value, setting.UserId);
            await repository.Save();
            return mapper.Map<FeatureSetting, FeatureSettingDto>(newSetting);
        }
        public async Task<string?> Get(string key, string? userId)
        {
            var setting = await repository.GetAsync(key, userId);
            return setting?.Value;
        }
    }
}
