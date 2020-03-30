using System.Collections.Generic;
using GraphQL.Types;
using Swipe.Api.Repositories;
using Swipe.Api.Data;

namespace Swipe.Api.GraphQL.Types
{
    public class PostQuery : ObjectGraphType
    {
        public PostQuery(PostRepository repository)
        {
            Field<ListGraphType<PostType>>(
                "posts", resolve: context => repository.GetAll());
        }
    }
}