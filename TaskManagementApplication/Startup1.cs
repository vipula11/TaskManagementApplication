using Microsoft.Owin;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementApplication.Services.Interfaces;
using TaskManagementApplication.Models;
using TaskManagementSystem.Model;
using Microsoft.EntityFrameworkCore;
using TaskManagementApplication.Services.Repo;

[assembly: OwinStartup(typeof(TaskManagementApplication.Startup1))]

namespace TaskManagementApplication
{
    public class Startup1
    {
        public Startup1(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
          
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TaskManagementContext>(options => options.UseSqlServer(Configuration.GetConnectionString("databaseconnection")));
            services.AddMvc();
            services.AddScoped<ITask, TaskRepo>();

        }
    }
}
