using GraphQL.Types;
using Swipe.Api.Data;

namespace Swipe.Api.GraphQL.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Tags);
            Field(t => t.ShortDesciption);
            Field(t => t.ImageUrl);
            
        }
    }
}