using ASP.NET.MVC.Models.Db.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ASP.NET.MVC.Models.Db.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context;
        public BlogRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task AddUser(User user)
        {
            var entry = _context.Entry(user);
            if (entry.State == EntityState.Detached)
                await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }
    }
}
