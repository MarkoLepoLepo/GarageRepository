using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garage48CoreAPI.Models;
using Garage48CoreAPI.Repository.Implementation;
using Garage48CoreAPI.Repository.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Garage48CoreAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PatientContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddTransient<IPatientInformationRepository, PatientInformationRepository>();
            services.AddTransient<IPersonalDatumRepository, PersonalDatumRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseCors(builder =>
                builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());

            app.UseMvcWithDefaultRoute();

        }
    }
}