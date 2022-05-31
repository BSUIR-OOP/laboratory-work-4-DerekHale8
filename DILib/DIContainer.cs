namespace DILib
{
    public class DIContainer
    {
        private List<ServiceDescriptor> descriptors;
        public DIContainer(List<ServiceDescriptor> descriptors)
        {
            this.descriptors = descriptors;
        }

        public T GetServiceType<T>()
            => (T)GetServiceType(typeof(T));

        private object GetServiceType(Type serviceType)
        {
            var service = descriptors.SingleOrDefault(x => x.ServiceType == serviceType);
            var descriptor = descriptors.SingleOrDefault(x => x.ServiceType == serviceType);
            if (descriptor.Implementation != null)
                return descriptor.Implementation;

            var actType = descriptor.ImplementationType == null ? descriptor.ServiceType : descriptor.ImplementationType;
            var constructorInfo = actType.GetConstructors()[0];
            object[] parameters = constructorInfo.GetParameters().Select(x => GetServiceType(x.ParameterType)).ToArray();
            var implementation = Activator.CreateInstance(actType, parameters);
            descriptor.Implementation = implementation;
            return implementation;
        }
    }
}