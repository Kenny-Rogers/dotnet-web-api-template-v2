using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Template.Domain.Models;
using WebProject.Template.Domain.Repositories;
using WebProject.Template.Domain.Services;
using WebProject.Template.Domain.Services.Communication;

namespace WebProject.Template.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();
                
                return new SaveCategoryResponse(category);
            }
            catch (Exception e)
            {
                return new SaveCategoryResponse($"An error occured when saving the category: {e.Message}");
            }
        }
    }
}