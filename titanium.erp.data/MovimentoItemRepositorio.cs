using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class MovimentoItemRepositorio: RepositorioBase<MovimentoItem>, IMovimentoItemRepositorio
    {
        public MovimentoItemRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
