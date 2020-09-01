using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Template.Domain.Models;

namespace WebProject.Template.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}