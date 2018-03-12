using API.DrugFRT.Configuration;
using API.DrugFRT.Framework.Infrastructure;
using API.DrugFRT.Framework.Interface;
using Ninject.Modules;

namespace API.DrugFRT.DependencyResolver.RepositoryLoadModule
{
    public class ThuocMobileRepositoryLoadModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConnectionFactory>()
                .To<SqlConnectionFactory>()
                .WithConstructorArgument("connectionString", ApiConfigurationManager.VendorSettings.ThuocMobileSetting.SqlCon);
        }
    }
}
