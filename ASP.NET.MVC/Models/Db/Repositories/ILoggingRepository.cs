using System.Threading.Tasks;

namespace ASP.NET.MVC.Models.Db.Repositories
{
    public interface ILoggingRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequests();
    }
}
