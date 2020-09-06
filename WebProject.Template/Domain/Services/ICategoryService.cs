using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Template.Domain.Models;
using WebProject.Template.Domain.Services.Communication;

namespace WebProject.Template.Domain.Services
{
    public interface ICategoryService
    {
        Task<Category> GetAsync(string id);
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}