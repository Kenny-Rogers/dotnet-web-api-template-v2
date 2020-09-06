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

        public async Task<Category> GetAsync(string id)
        {
            return await _categoryRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

        public async Task<CategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();
                
                return new CategoryResponse(category);
            }
            catch (Exception e)
            {
                return new CategoryResponse($"An error occured when saving the category: {e.Message}");
            }
        }

        public async Task<CategoryResponse> UpdateAsync(int id, Category category)
        {
            var existingCategory = await _categoryRepository.FindByIdAsync(id);
            
            if(existingCategory == null) return new CategoryResponse("Category not found.");

            existingCategory.Name = category.Name;

            try
            {
                _categoryRepository.Update(existingCategory);
                await _unitOfWork.CompleteAsync();
                
                return new CategoryResponse(existingCategory);
            }
            catch (Exception e)
            {
                return new CategoryResponse($"An error occured when updating the category: {e.Message}");
            }
        }

        public async Task<CategoryResponse> DeleteAsync(int id)
        {
            var existingCategory = await _categoryRepository.FindByIdAsync(id);
            
            if(existingCategory == null)
                    return new CategoryResponse("Category not found");

            try
            {
                _categoryRepository.Remove(existingCategory);
                await _unitOfWork.CompleteAsync();
                
                return new CategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                //do some logging stuff
                return new CategoryResponse($"An error occured when deleting the category: {ex.Message}");
            }
        }
        
        
    }
}