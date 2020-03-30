using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Swipe.Api.Data;

namespace Swipe.Api.Repositories
{
    public class PostRepository
    {
        private readonly SwipeDBContext _dbContext;

        public PostRepository(SwipeDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public Task<List<Post>> GetAll()
        {
            return _dbContext.Posts.ToListAsync();
        }

        public Task<Post> GetPost(int id)
        {
            return _dbContext.Posts.FirstOrDefaultAsync(t => t.Id == id);
        }
        public Task<Post> GetRandomPostBack()
        {
            var count = _dbContext.Posts.CountAsync().Result;
            Random rand = new Random();
            int id = rand.Next(count+1);
           return _dbContext.Posts.FirstOrDefaultAsync(t => t.Id == id);
        }


        public Task<Post> GetRandomPost()
        {
            return Task.Run(() => {
                var x = _dbContext.Posts.ToListAsync().Result;
                Random rand = new Random();
                return x[rand.Next(x.Count)];
            });
            
        }
    }
}