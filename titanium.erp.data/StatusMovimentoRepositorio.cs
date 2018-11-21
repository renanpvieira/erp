using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class StatusMovimentoRepositorio: RepositorioBase<StatusMovimento>, IStatusMovimentoRepositorio
    {
        public StatusMovimentoRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
