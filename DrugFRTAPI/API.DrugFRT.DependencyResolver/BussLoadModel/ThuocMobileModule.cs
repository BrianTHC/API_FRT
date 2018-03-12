using API.DrugFRT.Repository.Interface;
using API.DrugFRT.Repository.Repositories;
using Ninject.Modules;

namespace API.DrugFRT.DependencyResolver.BussLoadModel
{
    public class ThuocMobileModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IThuocMobileRepository>().To<ThuocMobileRepository>();
        }
    }
}
