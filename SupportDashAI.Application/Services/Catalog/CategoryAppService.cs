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
    public class CategoryAppService
    {
        private readonly ICategoryRepository repository;
        private readonly IMapper mapper;

        public CategoryAppService(ICategoryRepository repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<CategoryDto>> GetAll()
        {
            var categories = await repository.GetAllAsync();

            return mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(categories);
        }
        public async Task<IEnumerable<CategoryDto>> GetList(int skipCount, string criteria)
        {
            var categories = await repository.GetListAsync(skipCount, criteria);
            
            return mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(categories);
        }
        public async Task<CategoryDto> Get(Guid id)
        {
            var category = await repository.GetAsync(id);

            return mapper.Map<Category, CategoryDto>(category);
        }
        public async Task Create(CategoryDto categoryDto)
        {
            var newCategory = mapper.Map<CategoryDto, Category>(categoryDto);
            newCategory.Id = Guid.NewGuid();
            await repository.InsertAsync(newCategory);
            await repository.Save();

        }
        public async Task Update(CategoryDto categoryDto)
        {
            var updatedCategory = mapper.Map<CategoryDto, Category>(categoryDto);
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
