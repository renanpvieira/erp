using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class MovimentoRepositorio: RepositorioBase<Movimento>, IMovimentoRepositorio
    {
        public MovimentoRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
