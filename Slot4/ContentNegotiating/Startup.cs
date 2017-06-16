using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ContentNegotiating
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
            .AddMvc()
            .AddMvcOptions(options =>
            {
                options.ReturnHttpNotAcceptable = true;
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