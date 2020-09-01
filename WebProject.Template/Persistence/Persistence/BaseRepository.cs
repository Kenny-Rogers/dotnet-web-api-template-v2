using WebProject.Template.Persistence.Contexts;

namespace WebProject.Template.Persistence.Persistence
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        protected BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}