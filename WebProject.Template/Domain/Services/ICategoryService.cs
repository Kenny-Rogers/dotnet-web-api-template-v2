using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Template.Domain.Models;
using WebProject.Template.Domain.Services.Communication;

namespace WebProject.Template.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
    }
}