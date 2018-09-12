namespace ShipServer
{
    using System;
    using System.IO;
    using GraphQL;
    using GraphQL.Http;
    using GraphQL.Types;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using Model;
    using Newtonsoft.Json;

    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<StarTrekQuery>();
            services.AddSingleton<ISchema, StarTrekSchema>();
            services.AddSingleton<StarshipInputType>();
            services.AddSingleton<StarshipMutation>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMiddleware<GraphQLMiddleware>();
        }
    }
}
