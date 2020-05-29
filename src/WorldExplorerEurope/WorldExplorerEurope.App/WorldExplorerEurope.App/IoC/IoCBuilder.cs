using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.ViewModels;

namespace WorldExplorerEurope.App.IoC
{
    public class IoCBuilder
    {
        public static ContainerBuilder DefaultContainerBuilder()
        {
            var container = new ContainerBuilder();

            container.RegisterType<MainViewModel>();

            container.RegisterType<APIservice>().As<IAPIinterface>();

            return container;
        }
    }
}
