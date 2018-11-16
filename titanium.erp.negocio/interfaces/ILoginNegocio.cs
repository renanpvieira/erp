using titanium.erp.dto;

namespace titanium.erp.negocio.interfaces
{
    public interface ILoginNegocio
    {
        LoginDTO Logar(string login);
        void Deslogar();

    }
}
