using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class OperacaoRepositorio: RepositorioBase<Operacao>, IOperacaoRepositorio
    {
        public OperacaoRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
