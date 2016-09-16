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
            Mapper.CreateMap<ItensPedido, ItensPedidoDTO>()
                 //.ForMember(dest => dest.Cliente, opt => opt.Ignore())
                 //.ForMember(dest => dest.Total, opt => opt.Ignore());
                 .ForMember(d => d.Cliente, o => o.MapFrom(p => p.Pedido.Cliente.PegaNome()))
                .ForMember(d => d.Total, o => o.MapFrom(p => p.PrecoTotal()));
        }
    }
}