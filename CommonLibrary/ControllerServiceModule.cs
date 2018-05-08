using System;
using Ninject.Modules;
using ControllerLayer;

namespace CommonLibrary
{
    internal class ControllerServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IControllerService>().To<ControllerService>();
        }
    }
}
