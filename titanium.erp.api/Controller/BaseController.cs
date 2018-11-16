using System;
using System.Web.Http;
using System.Web.Http.Dependencies;
using titanium.erp.negocio.interfaces;

namespace titanium.erp.api.Controller
{
    public abstract class BaseController : ApiController
    {
        private Lazy<ILoginNegocio> _loginNegocio;
        public Lazy<ILoginNegocio> LoginNegocio
        {
            get
            {
                if (_loginNegocio == null)
                {
                    _loginNegocio = GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof(Lazy<ILoginNegocio>)) as Lazy<ILoginNegocio>;
                }
                return _loginNegocio;
            }
        }

    }
}