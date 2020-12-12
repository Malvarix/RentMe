using Application.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.Configurations;
using Persistence.Contexts;
using Persistence.ServiceInterfaces;
using Persistence.Services;
using MediatR;

namespace BikesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private const string AngularCorsPolicy = "_angularCorsPolicy";

        public void ConfigureServices(IServiceCollection services)
        {
            // DIs for BikesDb (EF)
            services.AddScoped<IBikeService, BikeService>();
            services.Configure<BikesDbConfiguration>(options =>
                options.BikesDbConnection = Configuration.GetSection("ConnectionStrings:BikesDbConnection").Value);
            services.AddMediatR(typeof(GetBikesAsyncQuery).Assembly);
            services.AddDbContext<BikesDbContext>(options => options
                .UseSqlServer(Configuration.GetSection("ConnectionStrings:BikesDbConnection").Value));

            services.AddControllers();

            // Add CORS policy
            services.AddCors(options =>
            {
                options.AddPolicy(name: AngularCorsPolicy, builder =>
                {
                    builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(AngularCorsPolicy);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
