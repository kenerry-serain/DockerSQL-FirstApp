using AutoMapper;
using DockerSQL.Application.Abstractions;
using DockerSQL.Application.WebAPI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;

namespace DockerSQL.Application.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvc();
            serviceCollection.AddNativeIoC(Configuration);
            serviceCollection.AddAutoMapper(typeof(IClientApplicationService));
            serviceCollection.AddSwaggerGen(options =>
            {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Info
                {
                    Title = "Docker-SQL API",
                    Version = "v1",
                    Description = "A Docker-SQL Application HTTP API",
                });
            });
        }

        public void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment environment, IServiceProvider serviceProvider)
        {
            if (environment.IsDevelopment())
            {
                applicationBuilder.UseDeveloperExceptionPage();
            }

            applicationBuilder.UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Docker-SQL.API V1");
                });

            applicationBuilder.UseStaticFiles();
            applicationBuilder.UseMvc();
        }
    }
}
