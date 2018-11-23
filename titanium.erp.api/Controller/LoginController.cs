using System;
using System.Data;
using System.Web.Http;
using titanium.erp.api.Configuration;
using titanium.erp.negocio.interfaces;
using Unity.Attributes;

namespace titanium.erp.api.Controller
{
    public class LoginController : BaseController
    {

        [Dependency]
        public Lazy<ILoginNegocio> LoginNegocio { get; set; }

        public string Get()
        {
           var x = this.LoginNegocio.Value.Logar("teste");

            return "";
        }

      
    }
}
