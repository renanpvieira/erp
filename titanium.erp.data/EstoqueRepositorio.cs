using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class EstoqueRepositorio : RepositorioBase<Estoque>, IEstoqueRepositorio
    {
        public EstoqueRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
