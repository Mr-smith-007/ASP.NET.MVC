using System.Threading.Tasks;

namespace ASP.NET.MVC.Models.Db.Repositories
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
    }
}
