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

    }
}