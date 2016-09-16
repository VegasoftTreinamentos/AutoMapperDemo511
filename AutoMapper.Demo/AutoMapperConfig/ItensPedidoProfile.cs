using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapper.Demo.Models.Dominio;
using AutoMapper.Demo.ViewModel;

namespace AutoMapper.Demo.AutoMapperConfig
{
    public class ItensPedidoProfile : Profile
    {
        public ItensPedidoProfile()
        {
            Mapper.CreateMap<ItensPedido, ItensPedidoDTO>();
        }
    }
}