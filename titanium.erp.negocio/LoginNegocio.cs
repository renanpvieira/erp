using titanium.erp.data;
using titanium.erp.dto;
using titanium.erp.negocio.interfaces;

namespace titanium.erp.negocio
{
    public class LoginNegocio : BaseNegocio, ILoginNegocio
    {

        public LoginNegocio(IUnitOfWork _uow)
        {
            UOW = _uow;
        }

        public void Deslogar()
        {
            UOW.CloseConnection();
        }

        public LoginDTO Logar(string login)
        {
            UOW.OpenConnection();

            return null;
        }

    }
}
