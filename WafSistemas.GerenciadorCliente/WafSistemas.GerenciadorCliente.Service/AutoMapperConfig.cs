using AutoMapper;
using WafSistemas.GerenciadorCliente.Domain.Entities;

namespace WafSistemas.CaixaFinanceiroAPI.Application.DI
{
    public static class AutoMapperConfig
    {
        public static IMapper Configuration()
        {
            var mapperconfiguration = new MapperConfiguration(Conf =>
            {
                Conf.CreateMap<GerenciadorCliente.Service.DTO.Cliente, Cliente>();
                Conf.CreateMap<Cliente, GerenciadorCliente.Service.DTO.Cliente>(); 
                Conf.CreateMap<GerenciadorCliente.Service.DTO.SendClienteRequest, Cliente>();

                Conf.CreateMap<GerenciadorCliente.Service.DTO.Projeto.Projeto, Projeto>();
                Conf.CreateMap<Projeto, GerenciadorCliente.Service.DTO.Projeto.Projeto>();
                Conf.CreateMap<GerenciadorCliente.Service.DTO.Projeto.AlterarProjetoRequest, Projeto>();
                Conf.CreateMap<Projeto, GerenciadorCliente.Service.DTO.Projeto.AlterarProjetoRequest>();
            });

            IMapper mapper = mapperconfiguration.CreateMapper();

            return mapper;

        }
    }
}
