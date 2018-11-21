using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class MovimentoStatusRepositorio : RepositorioBase<MovimentoStatus>, IMovimentoStatusRepositorio
    {
        public MovimentoStatusRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
