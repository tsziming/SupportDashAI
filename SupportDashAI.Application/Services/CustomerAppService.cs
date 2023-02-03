using AutoMapper;
using AutoMapper.Internal.Mappers;
using SupportDashAI.Contracts.Dto.Customer;
using SupportDashAI.Domain.Repositories;
using SupportDashAI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Application.Services
{
    public class CustomerAppService
    {
        private readonly ICustomerRepository repository;
        private readonly IMapper mapper;

        public CustomerAppService(
            ICustomerRepository repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CustomerListOptionDto>> GetAll() 
        {
            var customers = await repository.GetAllAsync();
            return mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerListOptionDto>>(customers);
        }
        public async Task<IEnumerable<CustomerListOptionDto>> GetByAgent(string agentId)
        {
            var customers = await repository.GetByAgentAsync(agentId);
            return mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerListOptionDto>>(customers);
        }
        public async Task<CustomerDto> Get(Guid customerId)
        {
            var customer = await repository.GetAsync(customerId);
            return mapper.Map<Customer, CustomerDto>(customer);
        }
        public async Task Create(CreateCustomerDto createDto)
        {
            var customer = mapper.Map<CreateCustomerDto, Customer>(createDto);
            customer.Id = Guid.NewGuid();
            await repository.InsertAsync(customer);
        }
        public async Task Delete(Guid id)
        {
            await repository.DeleteAsync(id);
        }
        public async Task UpdateNotes(UpdateCustomerDto updateCustomerDto)
        {
            var customer = await repository.GetAsync(updateCustomerDto.Id);
            customer.Name = updateCustomerDto.Name;
            customer.Notes = updateCustomerDto.Notes;
            await repository.UpdateAsync(customer);
        }
    }
}
