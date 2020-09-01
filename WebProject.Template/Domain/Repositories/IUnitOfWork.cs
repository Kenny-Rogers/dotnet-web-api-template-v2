using System.Threading.Tasks;

namespace WebProject.Template.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}