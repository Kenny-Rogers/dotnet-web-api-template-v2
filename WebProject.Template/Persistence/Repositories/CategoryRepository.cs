using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProject.Template.Domain.Models;
using WebProject.Template.Domain.Repositories;
using WebProject.Template.Persistence.Contexts;

namespace WebProject.Template.Persistence.Repositories
{
    public class CategoryRepository:BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }
    }
}