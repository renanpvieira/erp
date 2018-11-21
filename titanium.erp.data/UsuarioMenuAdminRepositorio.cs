using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class UsuarioMenuAdminRepositorio : RepositorioBase<UsuarioMenuAdmin>, IUsuarioMenuAdminRepositoio
    {
        public UsuarioMenuAdminRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
