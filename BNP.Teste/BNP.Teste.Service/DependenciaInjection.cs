using BNP.Teste.Dominio.Repository.Entities;
using BNP.Teste.Infra.Data.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace BNP.Teste.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection Configuration(IServiceCollection service)
        {
            service.AddScoped<IProdutoCosifRepository, ProdutoCosifRepository>();

            return service;
        }
    }
}
