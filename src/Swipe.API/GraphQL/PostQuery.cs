using System;
using GraphQL;
using GraphQL.Types;
using Swipe.Api.GraphQL.Types;
using Swipe.Api.Repositories;

namespace Swipe.Api.GraphQL
{
    public class PostQuery : ObjectGraphType<object>
    {

        public PostQuery(PostRepository repository)
        {
            Field<ListGraphType<PostType>>(
                "posts", resolve: context => repository.GetAll());

            Field<PostType>(
                "post",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                { Name = "id" }),
                resolve: context => 
                {
                    var id = context.GetArgument<int>("id");
                    return repository.GetPost(id);
                });

            Field<PostType>(
                "randomPost",
                resolve: context => repository.GetRandomPost());
        }
    }
}