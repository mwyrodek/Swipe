using GraphQL.Client.Http;
using System.Text.Json;
using Swipe.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swipe.Web.Clients
{
    public class PostGraphClient
    {
        GraphQLHttpClient client;
        public PostGraphClient(GraphQLHttpClient client)
        {
            this.client = client;
        }

        public async Task<PostModel> GetPost(int id)
        {
            var query = new GraphQLHttpRequest
            {
                Query = @"
                query getPost($pid: ID!)
                {  
                    post(id: $pid)
                    {    
                        title
                        url
                        shortDesciption
                        imageUrl
                    }
                }",
                Variables = new { pid = id }
            };

            var response = await client.SendQueryAsync<PostContainer>(query);
            return response.Data.Post;
        }

        public async Task<PostModel> GetRandomPost()
        {
            var query = new GraphQLHttpRequest
            {
                Query = @"
                    query getRandomPost
                    {  
                        post: randomPost
                        {    
                            title
                            url
                            shortDesciption
                            imageUrl
                        }
                    }",
            };
            var response = await client.SendQueryAsync<PostContainer>(query);
            return response.Data.Post;
        }

    }
}
