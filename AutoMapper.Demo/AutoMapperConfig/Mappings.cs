using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper.Demo.AutoMapperConfig
{
    public static class Mappings
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => // In Application_Start()
            {
                cfg.AddProfile<ClienteProfile>();
                cfg.AddProfile<PedidoProfile>();
               // cfg.AddProfile<ItensPedidoProfile>();
            });

            // Validador do Mapping
            Mapper.AssertConfigurationIsValid();
        }
    }
}