using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Car.BLL.Interfaces;
using Car.BLL.Services;
using Car.DAL.Interfaces;
using Car.DAL.Repositories;
using Car.BLL.MapperProvider;
using Car.Api.MapperProvider;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Car.DAL.Entities;

namespace Car.Api
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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<CarDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CarDbConnection")));

            services.AddSingleton(cm => AutoMapperConfig.ConfigureAutoMapper());
            services.AddSingleton<IAutoMapperProvider, AutoMapperProvider>();
            InitializationDependencyInjection(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseCors("CorsPolicy");
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }

        private void InitializationDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICarsService, CarService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ISupportService, SupportService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ISupportRepository, SupportRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

        }
    }
}
