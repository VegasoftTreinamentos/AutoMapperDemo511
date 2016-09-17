using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapper.Demo.Models.Dominio;
using AutoMapper.Demo.ViewModel;

namespace AutoMapper.Demo.AutoMapperConfig
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            this.CreateMap<Cliente, ClienteDTO>()
                 .ForMember(destino => destino.Bio, o => o.NullSubstitute("Não foi informado."))
                .ForMember(destino => destino.NomeCompleto, o => o.MapFrom(p => p.PegaNome()));
        }       
    }
}
