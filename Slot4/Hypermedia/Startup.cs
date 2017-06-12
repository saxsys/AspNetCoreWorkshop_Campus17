using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Halcyon.Web.HAL.Json;

namespace Hypermedia
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
            .AddMvcCore()
            .AddMvcOptions(options =>
            {
                options.ReturnHttpNotAcceptable = true;
                options.OutputFormatters.Add(new JsonHalOutputFormatter(new[] { "application/hal+json" }));
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("End of pipeline!");
            });
        }
    }
}