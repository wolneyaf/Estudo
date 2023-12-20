using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Infra.Data.Entities;
using BNP.Teste.Service.Interface;
using BNP.Teste.Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace BNP.Teste.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection Configuration(IServiceCollection service)
        {
            service.AddScoped<IProdutoRepository, ProdutoRepository>();
            service.AddScoped<IProdutoCosifRepository, ProdutoCosifRepository>();
            service.AddScoped<IMovimentoRepository, MovimentoRepository>();

            service.AddScoped<IMovimentoService, MovimentoService>();
            service.AddScoped<IProdutoCosifService, ProdutoCosifService>();
            service.AddScoped<IMovimentoService, MovimentoService>();

            return service;
        }
    }
}
