using Ninject.Modules;
using BusinessLayer;

namespace CommonLibrary
{
    internal class BusinessServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBusinessService>().To<BusinessService>();
        }
    }
}
