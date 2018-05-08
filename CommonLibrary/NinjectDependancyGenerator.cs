using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using ControllerLayer;

namespace CommonLibrary
{
    public class NinjectDependancyGenerator
    {
        private static IKernel _mainKernel;

        public static IKernel MainKernel
        {
            get { return _mainKernel; }
            private set { _mainKernel = value; }
        }

        static NinjectDependancyGenerator()
        {
            var mainKernel = new StandardKernel();
            _mainKernel = mainKernel;

            var serviceModules = new List<INinjectModule>
            {
                new RepositoryModule(),
                new BusinessServiceModule(),
                new ControllerServiceModule()
            };

            _mainKernel.Load(serviceModules);
        }

        private static T GetServiceInstance<T>()
        {
            return _mainKernel.Get<T>();
        }

        public static IControllerService GetControllerService()
        {
            return GetServiceInstance<IControllerService>();
        }
    }
}
