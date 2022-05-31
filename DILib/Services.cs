using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DILib
{
    public class Services
    {
        private List<ServiceDescriptor> listOfServices = new List<ServiceDescriptor>();

        public void AddSingelton<ServiceType, ImplementationType>()
            => listOfServices.Add(new ServiceDescriptor(typeof(ServiceType), typeof(ImplementationType), ServiceTime.Singleton));

        public void AddTransient<ServiceType, ImplementationType>()
            => listOfServices.Add(new ServiceDescriptor(typeof(ServiceType), typeof(ImplementationType), ServiceTime.Transient));

        public DIContainer GetContainer()
            => new DIContainer(listOfServices);
    }
}
