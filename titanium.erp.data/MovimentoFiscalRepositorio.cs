using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class MovimentoFiscalRepositorio: RepositorioBase<MovimentoFiscal>, IMovimentoFiscalRepositorio
    {
        public MovimentoFiscalRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
