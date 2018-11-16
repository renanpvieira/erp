using System;
using System.Web.Http;
using titanium.erp.negocio.interfaces;

namespace titanium.erp.api.Controller
{
    public class LoginController : BaseController
    {
      
        public string Get()
        {
           var x = this.LoginNegocio.Value.Logar("teste");

            return "";
        }

      
    }
}
