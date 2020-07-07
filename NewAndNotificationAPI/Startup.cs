using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NewAndNotificationAPI.Data;
using Newtonsoft.Json.Serialization;

namespace NewAndNotificationAPI
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
           services.AddDbContext<NewAndNotificationContext>(opt =>opt.UseSqlServer(
                Configuration.GetConnectionString("NewAndNotificationAPIConnection")));

            //  var server = Configuration["DBServer"] ?? "ms-sql-server";
            //  var port = Configuration["DBPort"] ?? "1433";
            //  var user = Configuration["DBUser"] ?? "sa";
            //  var password = Configuration["DBPassword"] ?? "Hello123#";
            //  var database = Configuration["Database"] ?? "SWDAPI";
            // services.AddDbContext<NewAndNotificationContext> (opt => 
            //     opt.UseSqlServer($"Data Source={server},{port};Initial Catalog={database};User ID={user};Password={password}"));

             
            // services.AddDbContext<NewAndNotificationContext> (opt =>opt.UseSqlServer
            // (Configuration.GetConnectionString("NewAndNotificationAPIConnection")));
            
             services.AddControllers().AddNewtonsoftJson(s=>{
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });


           services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
             services.AddScoped<ITopicRepo, SqlTopicRepo>();
              services.AddScoped<ITagRepo, SqlTagRepo>();
            services.AddMvc();

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //SWAGGER
             app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); 
            });
        }
    }
}
