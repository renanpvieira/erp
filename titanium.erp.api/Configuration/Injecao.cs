using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Data;
using System.Web.Http;
using titanium.erp.data;
using titanium.erp.negocio;
using titanium.erp.negocio.interfaces;
using MySql.Data.MySqlClient;

namespace titanium.erp.api.Configuration
{

   


    public class Injecao
    {
        private static Container _container;

        public static SimpleInjectorWebApiDependencyResolver Registar()
        {
            _container = new Container();
            _container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            
            _container.RegisterInstance<IDbConnection>(new MySqlConnection(""));
            _container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);

            _container.Register<Lazy<ILoginNegocio>>(() => new Lazy<ILoginNegocio>(_container.GetInstance<LoginNegocio>));
            
            _container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            _container.Verify();
            return new SimpleInjectorWebApiDependencyResolver(_container);
        }

      
    }
}