using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class UFRepositorio : RepositorioBase<UF>, IUFRepositorio
    {
        public UFRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
