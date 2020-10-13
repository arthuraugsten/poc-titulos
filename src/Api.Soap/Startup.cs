using Core.Abstracoes;
using Infra.Servicos;
using Infra.Servicos.Soap;
using Infra.Validadores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace Api.Soap
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
            => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IConversorFactory, ConversorFactory>();
            services.AddScoped<IValidadorFactory, ValidadorFactory>();

            services.AddScoped<Validador43>();
            services.AddScoped<Validador44>();

            services.AddScoped<IEnumerable<IValidador>>(sp =>
                new[] {
                    sp.GetRequiredService<Validador43>(),
                    sp.GetRequiredService<Validador44>() as IValidador
                }
            );

            services.AddScoped<ConversorSoap43>();
            services.AddScoped<ConversorSoap44>();

            services.AddScoped<IEnumerable<IConversor>>(sp =>
                new[] {
                    sp.GetRequiredService<ConversorSoap43>(),
                    sp.GetRequiredService<ConversorSoap44>()as IConversor
                }
            );

            services.AddControllers();
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
