using GraphQL;
using GraphQL.Types;
using Swipe.Api.GraphQL.Types;

namespace Swipe.Api.GraphQL
{
    public class BlogPostShema : Schema
    {
        public BlogPostShema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PostQuery>();
        }   
    }
}