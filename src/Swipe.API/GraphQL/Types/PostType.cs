using GraphQL.DataLoader;
using GraphQL.Types;
using Swipe.Api.Data;
using Swipe.API.Repositories;

namespace Swipe.Api.GraphQL.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType(TagsRepositorty tagsRepository)
        {
            Field(t => t.Id);
            Field(t => t.Url);
            Field(t => t.ImageUrl).Description("Link to title image"); ;
            Field(t => t.Title).Description("Tittle of the article");
            Field(t => t.ShortDesciption).Description("Meta description of the article");
            Field(t => t.IntroducedAt).Description("Date of adding article");
            Field(t => t.Opened).Description("how many times artilce was opened");
            Field(t => t.Ignored).Description("how many times artilce was ignored");

          /*  Field<ListGraphType<API.GraphQL.Types.TagType>>(
                "tags",

                resolve: context => tagsRepository.GetTagsForProduct(context.Source.Id)
        );*/

        }
    }
}