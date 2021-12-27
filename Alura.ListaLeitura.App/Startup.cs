using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Alura.ListaLeitura.App {
    // métodos de iniciaização
    public class Startup {
        // adicionando o serviço de roteamento do Asp.Net Core
        public void ConfigureServices(IServiceCollection services) {

            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app) {

            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();
     
        }
    }
}