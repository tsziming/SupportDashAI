using AutoMapper;
using SupportDashAI.Contracts.Dto.Catalog;
using SupportDashAI.Domain.Repositories.Catalog;
using SupportDashAI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Application.Services.Catalog
{
    public class ProductAppService
    {
        private readonly IProductRepository repository;
        private readonly IMapper mapper;

        public ProductAppService(IProductRepository repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var products = await repository.GetAllAsync();

            return mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
        }
        public async Task<IEnumerable<ProductDto>> GetList(int skipCount, string criteria)
        {
            var products = await repository.GetListAsync(skipCount, criteria);

            return mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
        }
        public async Task<ProductDto> Get(Guid id)
        {
            var product = await repository.GetAsync(id);

            return mapper.Map<Product, ProductDto>(product);
        }
        public async Task Create(UpdateProductDto productDto)
        {
            var newProduct = mapper.Map<UpdateProductDto, Product>(productDto);
            newProduct.Id = Guid.NewGuid();
            await repository.InsertAsync(newProduct);
            await repository.Save();

        }
        public async Task Update(UpdateProductDto productDto)
        {
            var updatedCategory = mapper.Map<UpdateProductDto, Product>(productDto);
            await repository.UpdateAsync(updatedCategory);
            await repository.Save();
        }
        public async Task Delete(Guid id)
        {
            await repository.DeleteAsync(id);
            await repository.Save();
        }
    }
}
