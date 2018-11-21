using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class MenuAdminRepositorio : RepositorioBase<MenuAdmin>, IMenuAdminRepositorio
    {
        public MenuAdminRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
