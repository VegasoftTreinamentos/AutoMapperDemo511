using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapper.Demo.Models.Dominio;
using AutoMapper.Demo.ViewModel;


namespace AutoMapper.Demo.AutoMapperConfig
{
    public class PedidoProfile     : Profile
    {
        public PedidoProfile()
        {
            this.CreateMap<Pedido, PedidoDTO>()
                .ForMember(d => d.NomeCliente, o => o.MapFrom(p => p.Cliente.PegaNome()))
                .ForMember(d => d.Total, o => o.MapFrom(p => p.TotalPedido()))
                //.ForMember(d => d.Entregar, o => o.ResolveUsing<ResolvedorBooleano>())
                //.ForMember(d => d.LinhaPedido, o => o.MapFrom(p => p.LinhaPedido))
                .ForMember(d => d.NrPedido, o => o.MapFrom(p => p.NumeroPedido));
        }
    }
}