using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.Teste.Service
{
    public static class AutoMapperConfig
    {
        public static IMapper Configuration()
        {
            var configurarion = new MapperConfiguration(conf => {
               
            });

            var mapper = configurarion.CreateMapper();

            return mapper;
        }
    }
}
