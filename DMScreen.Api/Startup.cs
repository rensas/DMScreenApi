using System;
using System.IO;
using System.Reflection;
using DMScreen.Core.Interfaces.Repositories;
using DMScreen.Core.Interfaces.Services;
using DMScreen.Core.Services;
using DMScreen.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using Microsoft.OpenApi.Models;

namespace DMScreen.Api
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
            services.AddMvcCore();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
            services.AddControllers();
            
            // Swagger setup
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DM Screen API", Version = "v1", Contact = new OpenApiContact() { Name = "Andrew Rens", Email = "rensas@protonmail.com" } });
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //c.IncludeXmlComments(xmlPath);
            });
            
            services.AddScoped<IPlayerCharacterService, PlayerCharacterService>();
            services.AddScoped<IPlayerCharacterRepository, PlayerCharacterMockRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            // Enable Swagger UI
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Coterie Sample Rating API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}