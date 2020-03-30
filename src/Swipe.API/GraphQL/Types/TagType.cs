using GraphQL.Types;
using Swipe.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swipe.API.GraphQL.Types
{
    public class TagType : ObjectGraphType<Tag>
    {
        public TagType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
        }
    }
}
