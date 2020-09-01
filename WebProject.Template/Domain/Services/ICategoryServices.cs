using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Template.Domain.Models;

namespace WebProject.Template.Domain.Services
{
    public interface ICategoryServices
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}