using MySql.Data.MySqlClient;
using System.Data;
using System.Web.Http;
using titanium.erp.data;
using titanium.erp.negocio;
using titanium.erp.negocio.interfaces;
using Unity;
using Unity.WebApi;

namespace titanium.erp.api.Configuration
{
    public class InjecaoUnity
    {
        private static readonly MySqlConnection dbConnection = new MySqlConnection();

        public static void RegistraComponentes()
        {
            var container = new UnityContainer();

            container.RegisterInstance<IDbConnection>(dbConnection);

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<ILoginNegocio, LoginNegocio>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

    }
}