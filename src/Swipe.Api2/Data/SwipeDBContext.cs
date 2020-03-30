using Microsoft.EntityFrameworkCore;

namespace Swipe.Api.Data
{
    public class SwipeDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=swipe.db");
    }
}