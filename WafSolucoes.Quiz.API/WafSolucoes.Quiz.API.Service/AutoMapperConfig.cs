using AutoMapper;
using WafSolucoes.Quiz.API.Domain.Entities;

namespace WafSolucoes.Quiz.API.Service
{
    public static class AutoMapperConfig
    {
        public static IMapper Configuration()
        {
            var mapperconfiguration = new MapperConfiguration(Conf =>
            {
                Conf.CreateMap<DTO.Pesquisa.Pesquisa, Pesquisa>();
                Conf.CreateMap<Pesquisa, DTO.Pesquisa.Pesquisa>();

                //Conf.CreateMap<GerenciadorCliente.Service.DTO.Cliente, Cliente>();
                //Conf.CreateMap<Cliente, GerenciadorCliente.Service.DTO.Cliente>(); 
                //Conf.CreateMap<GerenciadorCliente.Service.DTO.SendClienteRequest, Cliente>();

                //Conf.CreateMap<GerenciadorCliente.Service.DTO.Projeto.Projeto, Projeto>();
                //Conf.CreateMap<Projeto, GerenciadorCliente.Service.DTO.Projeto.Projeto>();
            });

            IMapper mapper = mapperconfiguration.CreateMapper();

            return mapper;

        }
    }
}
