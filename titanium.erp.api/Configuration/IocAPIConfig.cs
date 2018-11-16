using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Web.Http;
using titanium.erp.negocio;
using titanium.erp.negocio.interfaces;

namespace titanium.erp.api.Configuration
{
    public class IocAPIConfig
    {
        public SimpleInjectorWebApiDependencyResolver Registar()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            //container.Register<ILoginNegocio, LoginNegocio>(Lifestyle.Scoped);

            container.Register<Lazy<ILoginNegocio>>(() => new Lazy<ILoginNegocio>(container.GetInstance<LoginNegocio>));

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();
            return new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}