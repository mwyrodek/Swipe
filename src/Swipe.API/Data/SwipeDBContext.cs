using Microsoft.EntityFrameworkCore;
using Swipe.API.Data;

namespace Swipe.Api.Data
{
    public class SwipeDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagPostMap> TagPostMaps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=swipe.db");
        
    }
}