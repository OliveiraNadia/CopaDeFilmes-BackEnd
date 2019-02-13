using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDeFilmes.Domain.Interfaces.Repository;
using CopaDeFilmes.Domain.Interfaces.Services;
using CopaDeFilmes.Infra.Repository;
using CopaDeFilmes.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace CopaDoMundoFilmes.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc();

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1",
            //        new Info
            //        {
            //            Title = "Copa do Mundo Filmes API",
            //            Version = "v1",
            //            Description = "API utilizada para identificar campeão e vice campeão entre uma lista de filmes"
            //        });
            //});

            ////Singleton pois não preciso variar o objeto.
            //services.AddSingleton<IFilmeRepository, FilmeRepository>();
            //services.AddSingleton<ICampeonatoService, CampeonatoService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseMvc();

            //app.UseSwagger();

            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json",
            //        "Copa do Mundo Filmes API");
            //});
        }
    }
}
