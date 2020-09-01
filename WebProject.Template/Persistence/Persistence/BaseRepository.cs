using WebProject.Template.Persistence.Contexts;

namespace WebProject.Template.Persistence.Persistence
{
    public class BaseRepository
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}