using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class CidadeRepositorio : RepositorioBase<Cidade>, ICidadeRepositorio
    {
        public CidadeRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
