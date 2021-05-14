using Fibonacci;
using System.ComponentModel.Design;

namespace Services
{

    public class ServiceRepository : IServiceRepository // Factory Design Pattern
    {
        private readonly ServiceContainer _serviceContainer;
        public ServiceRepository()
        {
            if (_serviceContainer == null)
                _serviceContainer = new ServiceContainer();
        }

        public MathService GetMathService()
        {
            var service = (MathService)_serviceContainer.GetService(typeof(MathService));
            if (service == null)
            {
                service = new MathService();
                _serviceContainer.AddService(typeof(MathService), service);
            }

            return service;
        }
    }
}
