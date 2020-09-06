using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Template.Domain.Models;

namespace WebProject.Template.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetAsync(string id);
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        void Update(Category category);
        void Remove(Category category);
    }
}