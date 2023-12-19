using Microsoft.Extensions.DependencyInjection;
using WafSistemas.GerenciadorCliente.Domain.Repository.Entities;
using WafSistemas.GerenciadorCliente.Infra.Repository.Data.Entities;
using WafSistemas.GerenciadorCliente.Service.Interface;
using WafSistemas.GerenciadorCliente.Service.Service;

namespace WafSistemas.GerenciadorCliente.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection Configuration(IServiceCollection service)
        {
            //Application
            service.AddScoped<IClienteService, ClienteService>();
            service.AddScoped<IProjetoService, ProjetoService>();

            //Repository
            service.AddScoped<IClienteRepository, ClienteRepository>();
            service.AddScoped<IProjetoRepository, ProjetoRepository>();


            return service;
        }
    }
}
