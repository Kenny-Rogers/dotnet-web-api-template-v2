using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Template.Domain.Models;
using WebProject.Template.Domain.Repositories;
using WebProject.Template.Domain.Services;

namespace WebProject.Template.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}