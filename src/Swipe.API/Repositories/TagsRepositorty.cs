using Microsoft.EntityFrameworkCore;
using Swipe.Api.Data;
using Swipe.API.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;

namespace Swipe.API.Repositories
{
    public class TagsRepositorty
    {
        private readonly SwipeDBContext _dbContext;
        DbSet<Tag> tags;
        DbSet<TagPostMap> tagPostMaps;
        public TagsRepositorty(SwipeDBContext dbContext)
        {
            _dbContext = dbContext;
            tags = _dbContext.Tags;
            tagPostMaps = _dbContext.TagPostMaps;
        }

        public Task<List<Tag>> GetAll()
        {
            return _dbContext.Tags.ToListAsync();
        }

        public Task<List<Tag>> GetTagsForProduct(int productId)
        {

            var query =
                from tag in tags
                join tagPostMap in tagPostMaps
                on tag.Id
                equals tagPostMap.TagId
                where tagPostMap.ProductId == productId
                select new Tag { Id = tag.Id, Name = tag.Name };

            return query.ToListAsync();
        }

        
    }
}
