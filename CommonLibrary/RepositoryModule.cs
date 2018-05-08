using System;
using Ninject.Modules;
using RepositoryLayer;

namespace CommonLibrary
{
    internal class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<Repository>();
        }
    }
}
