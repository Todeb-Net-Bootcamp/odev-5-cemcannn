using Business.Abstract;
using Business.Concrete;
using Business.Configuration.Mapper;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EF;
using DataAccessLayer.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
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
            services.AddAutoMapper(config =>  
            {
                config.AddProfile(new MapperProfile());
            }); //AutoMapper'ýn hangi Profile'ý kullanacaðýný belirtiyoruz.
            
            services.AddDbContext<TodebCampDbContext>(ServiceLifetime.Transient); //Hangi contexti kullanacaðýný belirtiyoruz. Dependency Injection lifetime olarak Transient kullanacaðýz.

            var companyName = Configuration.GetValue<string>("CompanyName"); //Appsettings.json'ýn CompanyName alanýný okuyoruz.
            if (companyName == "KahveDunyasi")
            {
                services.AddScoped<ICustomerService, KahveDunyasiCustomerService>(); //KahveDunyasi'na ait CustomerService'ý kullanacaðýmýzý belirtiyoruz.
            }
            else
            {
                services.AddScoped<ICustomerService, CustomerService>(); //CustomerService'ý kullanacaðýmýzý belirtiyoruz.
            }
            
            services.AddScoped<ICustomerService, CustomerService>(); //ICustomerService interface'i CustomerService sýnýfýný implemente edecek ve Dependency Injection lifetime olarak Scoped kullanacaðýz.
            services.AddScoped<ICustomerRepository, EFCustomerRepository>(); //ICustomerRepository interface'i CustomerRepository sýnýfýný implemente edecek ve Dependency Injection lifetime olarak Scoped kullanacaðýz.
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
