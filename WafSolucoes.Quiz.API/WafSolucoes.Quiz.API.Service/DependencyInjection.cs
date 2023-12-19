using Microsoft.Extensions.DependencyInjection;
using WafSolucoes.Quiz.API.Domain.Repository.Entities;
using WafSolucoes.Quiz.API.Infra.Repository.Data.Entities;
using WafSolucoes.Quiz.API.Service.Interface;
using WafSolucoes.Quiz.API.Service.Service;

namespace WafSolucoes.Quiz.API.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection Configuration(IServiceCollection service)
        {
            //Application            
            //service.AddScoped<IPesquisaService, Service.Service.PesquisaService>();

            service.AddScoped<IPesquisaService, PesquisaService>();
            //service.AddScoped<IPesquisaService, PesquisaService>();

            //Repository
            service.AddScoped<IPesquisaRepository, PesquisaRepository>();
            service.AddScoped<IPerguntaRepository, PerguntaRepository>();
            service.AddScoped<IQuestaoRepository, QuestaoRepository>();
            service.AddScoped<IRespostaRepository, RespostaRepository>();
            service.AddScoped<IQuestionarioRepository, QuestionarioRepository>();

            return service;
        }
    }
}
