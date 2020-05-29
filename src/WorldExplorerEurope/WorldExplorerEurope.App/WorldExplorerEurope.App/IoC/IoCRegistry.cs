using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldExplorerEurope.App.IoC
{
    public class IoCRegistry
    {
        private static IContainer container;
        public static IContainer Container
        {
            get
            {
                if(container == null)
                {
                    var builder = IoCBuilder.DefaultContainerBuilder();
                    container = builder.Build();
                }
                return container;
            }
        }
    }
}
