using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swipe.Api.Data;
using Swipe.Api.GraphQL;
using Swipe.Api.Repositories;
using Swipe.API.Repositories;

namespace Swipe.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SwipeDBContext>();
            services.AddScoped<PostRepository>();
            services.AddScoped<TagsRepositorty>();
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(
                s.GetRequiredService));
            services.AddScoped<BlogPostSchema>();

            services.AddLogging(builder => builder.AddConsole());
         //   services.AddSingleton<ISchema, BlogPostSchema>();
            services.AddGraphQL(o => { o.ExposeExceptions = true; o.EnableMetrics = true; })
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddDataLoader();
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, SwipeDBContext dbContext)
        //public void Configure(IApplicationBuilder app)
        {
            app.UseGraphQL<BlogPostSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
            dbContext.Seed();
        }
    }
}