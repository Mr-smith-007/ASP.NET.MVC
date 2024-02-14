using Microsoft.EntityFrameworkCore;

namespace ASP.NET.MVC.Models.Db.Context
{
    public class LoggingContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public LoggingContext(DbContextOptions<LoggingContext> options) : base(options)
        {
            Database.EnsureCreated(); 
        }
    }
}
