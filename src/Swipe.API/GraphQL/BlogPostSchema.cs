using GraphQL;
using GraphQL.Types;
using Swipe.Api.GraphQL.Types;

namespace Swipe.Api.GraphQL
{
    public class BlogPostSchema : Schema
    {
        public BlogPostSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PostQuery>();
        }   
    }
}