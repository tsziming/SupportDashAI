using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SupportDashAI.Contracts.Dto;
using SupportDashAI.Contracts.Dto.Catalog;
using SupportDashAI.Contracts.Dto.Customer;
using SupportDashAI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Application
{
    public class AutoMapperApplicationProfile: Profile
    {
        public AutoMapperApplicationProfile()
        {
            // Catalog
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<UpdateProductDto, Product>();
            CreateMap<UpdateProductDto, ProductDto>().ReverseMap();

            // Agent
            CreateMap<IdentityUser, AgentDto>();
            CreateMap<AgentResponse, AgentResponseDto>().ReverseMap();
            CreateMap<AgentResponseTip, AgentResponseTipDto>().ReverseMap();

            // Customer
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, CustomerListOptionDto>().ReverseMap();
            CreateMap<CustomerRequest, CustomerRequestDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();

            // Administration
            CreateMap<FeatureSetting, FeatureSettingDto>().ReverseMap();

        }
    }
}
