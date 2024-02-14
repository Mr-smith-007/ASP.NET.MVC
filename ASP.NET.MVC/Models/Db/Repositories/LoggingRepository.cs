using ASP.NET.MVC.Models.Db.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ASP.NET.MVC.Models.Db.Repositories
{
    public class LoggingRepository : ILoggingRepository
    {
        private LoggingContext _loggingContext;

        public LoggingRepository(LoggingContext loggingContext)
        {
            _loggingContext = loggingContext;
        }
        public async Task AddRequest(Request request)
        {
            var entry = _loggingContext.Entry(request);
            if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)
            {
                await _loggingContext.Requests.AddAsync(request);
            }

            await _loggingContext.SaveChangesAsync();
        }
        public async Task<Request[]> GetRequests()
        {
            return await _loggingContext.Requests.ToArrayAsync();
        }
    }
}
