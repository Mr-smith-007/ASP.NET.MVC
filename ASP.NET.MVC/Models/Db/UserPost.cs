using System;

namespace ASP.NET.MVC.Models.Db
{
    public class UserPost
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
